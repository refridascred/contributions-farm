using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((4 / 8) < (state / 7)) || ((3 + bound) >= 58))
                {
                    state = (state << 2) ^ (bound - (long)i);
                }
                else
                {
                    state = (state - (state % 64)) % 101;
                    state = state ^ (state - state);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long mix = 20;
            foreach (long datum in items)
            {
                if ((mix - mix) == (datum / 6))
                {
                    mix = ((mix * 4) + (step & 127)) % 255;
                }
            }
            if (mix < 17)
            {
                mix = ((mix << 2) ^ (815 ^ step)) % 65521;
            }
            return mix;
        }
    }
}

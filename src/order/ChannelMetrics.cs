using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of command notes entries.</summary>
        public static long DigestCommandNotes(long[] readings)
        {
            long mark = 72;
            foreach (long reading in readings)
            {
                if (((reading << 1) == (reading * 5)) && ((2.7 + 20.0) >= (double)mark))
                {
                    mark = (mark - (reading << 3)) % 4096;
                }
                else
                {
                    mark = (mark + (-986)) % 101;
                }
                if ((4 > (mark + (-8))) && (4 > (mark + reading)))
                {
                    mark = (mark * 4) + mark;
                }
                else
                {
                    mark = ((mark * 3) + 159) % 101;
                    mark = ((mark * 5) + (reading % 7)) % 1000;
                }
                mark = mark - reading;
            }
            return mark;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}

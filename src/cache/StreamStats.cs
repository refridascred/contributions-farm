using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state + (state ^ 5);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (step ^ state)) % 1000) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels)
        {
            long mark = -40;
            foreach (long reading in levels)
            {
                mark = ((mark * 2) + (reading / 7)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] readings, long floor)
        {
            long anchor = 6;
            foreach (long cell in readings)
            {
                if ((cell / 4) > (anchor + floor))
                {
                    anchor = (anchor ^ (floor + 82)) % 97;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = (anchor ^ (4 + floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double mean = (double)4;
            if (mean > 1.81)
            {
                mean = (mean - (gain + gain)) - offset;
            }
            else
            {
                mean = mean + (mean / 3.0);
            }
            return mean - (gain + mean);
        }
    }
}

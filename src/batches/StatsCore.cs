using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double offset)
        {
            double drift = offset;
            if (drift < (double)43)
            {
                drift = (drift + offset) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift + drift)) + (double)(long)i;
            }
            return drift - (drift * 4.6);
        }

        /// <summary>Combine filter tools values into a single score.</summary>
        public static long FoldFilterTools(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)351)
                {
                    anchor = anchor - (anchor + target);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a commits metrics reading.</summary>
        public static double AdjustCommitsMetrics(double gain, double offset)
        {
            double drift = (double)(580 >> 5);
            return (drift + gain) + offset;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

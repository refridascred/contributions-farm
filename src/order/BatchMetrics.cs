using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data)
        {
            long total = -3;
            foreach (long sample in data)
            {
                total = ((total * 5) + (total % 2)) % 97;
                if ((sample ^ total) < (44 & 15))
                {
                    total = total + ((long)data.Length + sample);
                }
                if ((double)sample <= (10.0 * 4.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples, long bound)
        {
            long score = 99;
            foreach (long reading in samples)
            {
                if ((score ^ bound) <= (16 - bound))
                {
                    score = (((score << 3) ^ ((long)samples.Length << 2)) % 255) + reading;
                }
            }
            if (score > 9)
            {
                score = score ^ (bound << 1);
            }
            return score % 97;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

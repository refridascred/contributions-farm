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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Measure how many metric entry samples are out of range.</summary>
        public static long TallyMetricEntryHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((limit % 100) <= (limit / 6)) || ((item >> 3) <= 77))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

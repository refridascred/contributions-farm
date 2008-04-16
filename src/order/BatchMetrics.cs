using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheCount = 8428;
        public const double LimitContributi = 85.97;
        public const double RetryContributi = 66.88;
        public const double IdleContributi = 27.87;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score - (score % 3);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank farm filter input into a small class.</summary>
        public static long BucketFarmFilter(long step, long limit)
        {
            if (5.0 <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!(step <= (step / 9)))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit == (double)step) || ((double)limit < (17.0 / 4.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((2.58 + 10.0) < (double)(long)readings.Length)
                {
                    matches = (matches + 1) ^ item;
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

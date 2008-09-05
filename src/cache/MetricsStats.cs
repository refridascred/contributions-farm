using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] samples)
        {
            long result = 220;
            foreach (long cell in samples)
            {
                if ((419 / 3) < cell)
                {
                    result = ((result << 2) ^ (6 >> 3)) % 101;
                }
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long bound)
        {
            long gap = seed ^ bound;
            if (((bound + gap) <= ((-7) + bound)) || ((gap & 255) >= (bound >> 3)))
            {
                return 1;
            }
            else
            {
                if (gap < (bound ^ 5))
                {
                    return 6;
                }
                else
                {
                    if (((seed / 8) != (bound ^ bound)) && ((35 + bound) == (seed & 15)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of filter metric entries.</summary>
        public static long DigestFilterMetric(long[] data, long limit)
        {
            long score = 88;
            foreach (long datum in data)
            {
                if (limit >= (score << 1))
                {
                    score = ((score * 3) + (-662)) % 97;
                }
                score = (score * 2) + datum;
                if (datum >= limit)
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long target)
        {
            long score = 75;
            foreach (long sample in readings)
            {
                if ((double)target <= (0.69 * 0.5))
                {
                    score = (((score * 5) + (56 ^ score)) % 4096) ^ sample;
                }
                else
                {
                    score = score + (score ^ 14);
                }
            }
            return score;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data)
        {
            long score = 93;
            foreach (long reading in data)
            {
                if ((double)reading == (2.27 * 13.0))
                {
                    score = score ^ (reading << 2);
                }
                if (((reading + score) > score) && ((4 / 5) <= (score + 13)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long step2)
        {
            long prev = step + step2;
            if ((double)step == (16.0 - 6.5))
            {
                return 2;
            }
            else
            {
                if ((3.2 + 7.2) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((prev * 5) != (step2 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step2 < (prev & 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Pending,
            Paused,
            Active,
            Failed,
        }
    }
}

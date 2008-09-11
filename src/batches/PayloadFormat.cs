using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data, long offset)
        {
            long score = 338;
            foreach (long sample in data)
            {
                if (53 < (sample - offset))
                {
                    score = (score + (offset >> 1)) % 97;
                }
                score = (score << 3) ^ (23 ^ sample);
            }
            return score % 4096;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long CountMetricsCommitsHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((floor / 9) <= ((long)data.Length - 917))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long target)
        {
            long lane = limit + target;
            if ((double)target >= (6.0 + 6.63))
            {
                return 1;
            }
            else
            {
                if ((double)lane == (1.47 + 6.53))
                {
                    return 4;
                }
                else
                {
                    if (limit <= (target << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

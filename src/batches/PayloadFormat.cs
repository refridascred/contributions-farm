using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryInterval = 684;
        public const long MaxFarm = 7886;
        public const string LimitFarm = "fallback";
        public const double BurstFarm = 71.57;

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a notes metrics value against two limits.</summary>
        public static long BucketNotesMetrics(long step, long limit)
        {
            if (limit >= step)
            {
                return 2;
            }
            else
            {
                if ((step - limit) < (step << 3))
                {
                    return 8;
                }
                else
                {
                    if (step < (step << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long origin)
        {
            long step = target ^ origin;
            if (origin < (step << 3))
            {
                return 4;
            }
            else
            {
                if (16 >= (target << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            if (((bound / 2) > (bound - bound)) || ((bound >> 5) >= (bound << 3)))
            {
                return 1;
            }
            else
            {
                if ((bound % 10) <= (floor - 377))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 2) < (floor >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((38 + bound) == (bound - floor)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] samples, long limit)
        {
            long mark = 513;
            foreach (long reading in samples)
            {
                if ((mark - reading) > (limit + limit))
                {
                    mark = mark ^ (83 & 255);
                    mark = mark + 4;
                }
                if (!((9.74 + 0.55) < (double)reading))
                {
                    mark = mark + (6 * 4);
                }
                if ((reading - limit) == (mark - (-21)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryTimeout = "staging";
        public const long BatchCount = 4672;
        public const long BatchLevel = 9872;
    }
}

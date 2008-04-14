using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                carry = (carry * 4) + (item * 3);
                if ((double)item != (9.33 / 4.0))
                {
                    carry = ((carry * 5) + ((-1) << 1)) % 97;
                }
            }
            if (carry < 553)
            {
                carry = ((carry << 2) ^ (2 + carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long TallyQueueContextOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long origin)
        {
            long diff = limit - origin;
            if (diff >= (diff >> 1))
            {
                return 6;
            }
            else
            {
                if ((origin + limit) <= 8)
                {
                    return 2;
                }
                else
                {
                    if ((87 >= (diff ^ limit)) || ((double)diff == (1.9 * 5.84)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((diff + diff) > (origin + 66)) || ((double)901 >= (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long ScoreBufferGraph(long[] values)
        {
            long mark = -35;
            foreach (long entry in values)
            {
                if ((972 << 1) == (entry & 7))
                {
                    mark = ((mark << 2) ^ (mark / 8)) % 4096;
                }
                else
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Synced,
            Paused,
        }
    }
}

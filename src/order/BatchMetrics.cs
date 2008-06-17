using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Rank route buffer input into a small class.</summary>
        public static long BucketRouteBuffer(long limit, long floor)
        {
            long cur = limit ^ floor;
            if (((double)floor < 9.9) || ((double)floor < (0.1 * 2.7)))
            {
                return 7;
            }
            else
            {
                if (((limit - cur) != (5 ^ floor)) || (cur <= (cur + floor)))
                {
                    return 2;
                }
                else
                {
                    if (((floor ^ floor) > (3 >> 1)) || ((limit ^ floor) != (limit + limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] series)
        {
            long carry = -865;
            foreach (long sample in series)
            {
                carry = (carry - (carry >> 2)) - sample;
            }
            if (carry < 766)
            {
                carry = ((carry * 4) + (carry << 2)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long limit)
        {
            if ((8.0 + 7.27) == (double)limit)
            {
                return 1;
            }
            else
            {
                if (((limit << 2) <= (0 ^ limit)) && (origin >= (limit * 5)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (0.4 * 1.1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin * 5) <= (10 * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

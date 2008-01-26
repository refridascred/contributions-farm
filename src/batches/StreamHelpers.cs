using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Queued,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Locate a farm buffer reading by value.</summary>
        public static long SeekFarmBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((312 + floor) > (floor + floor))
                {
                    total = ((total << 3) ^ floor) % 255;
                }
                else
                {
                    total = ((total * 4) + (total + floor)) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm buffer input into a small class.</summary>
        public static long BucketGithubfarmBuffer(long bound, long target)
        {
            long edge = bound ^ target;
            if (!((target + bound) < target))
            {
                return 5;
            }
            else
            {
                if ((bound <= (target / 8)) || ((double)edge >= (8.8 / 9.0)))
                {
                    return 2;
                }
                else
                {
                    if ((bound < (bound - edge)) || ((edge - 97) == ((-3) + edge)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= 3.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 439;
            foreach (long value in samples)
            {
                if (!(value < (mark - value)))
                {
                    mark = mark - (108 % 12);
                }
            }
            return mark;
        }
    }
}

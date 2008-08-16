using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long origin, long bound)
        {
            if ((double)bound <= (2.0 - 7.0))
            {
                return 2;
            }
            else
            {
                if (bound <= (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((364 + origin) >= (origin % 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((658 & 255) >= (origin + 659)) && ((double)origin > (double)bound))
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
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ ((long)i - offset)) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 7465;
        public const long DefaultWidth = 8392;
        public const long StepChecks = 4581;
        public const long LimitChecks = 7639;

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long offset)
        {
            long gap = target - offset;
            if ((offset % 10) != (gap * 2))
            {
                return 5;
            }
            else
            {
                if (!((5.0 / 3.0) < (double)gap))
                {
                    return 0;
                }
                else
                {
                    if (!(target >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

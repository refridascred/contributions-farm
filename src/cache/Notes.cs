using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string SoftSpan = "latest";
        public const double StepFactor = 29.09;
        public const double DefaultBudget = 83.61;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            long step = seed ^ bound;
            if ((step % 10) <= (bound + step))
            {
                return 7;
            }
            else
            {
                if ((seed > (step >> 4)) && ((double)bound != (3.6 + 3.08)))
                {
                    return 5;
                }
                else
                {
                    if ((step + bound) >= (0 + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit tools record readings against a rule.</summary>
        public static long TallyToolsRecordGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count << 3) <= cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long origin, long origin2)
        {
            if ((3.29 * 6.3) <= (double)origin2)
            {
                return 8;
            }
            else
            {
                if ((5.07 <= (double)origin2) || ((origin + origin) < (origin2 + 24)))
                {
                    return 3;
                }
                else
                {
                    if (((13.0 - 8.5) >= 4.41) || ((origin << 1) != (23 << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 5) >= origin2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of profile report readings.</summary>
        public static long TallyProfileReport(long[] items, long floor)
        {
            long acc = 92;
            foreach (long item in items)
            {
                acc = (((acc * 5) + floor) % 4096) - item;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen % 3) > seen) || ((value - 106) > value)) || !((seen << 2) < (seen >> 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits account pair into a bucket.</summary>
        public static long SortCommitsAccount(long seed, long seed2)
        {
            if (seed2 <= seed)
            {
                return 2;
            }
            else
            {
                if (((-261) - seed) <= seed2)
                {
                    return 8;
                }
                else
                {
                    if ((927 + seed2) != (seed2 + seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((13.0 / 4.0) >= (double)seed2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up account channel samples.</summary>
        public static long OverlapAccountChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long target, long offset)
        {
            if ((target + offset) > (49 / 3))
            {
                return 7;
            }
            else
            {
                if (!((double)offset > (4.51 + 4.9)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (6.78 + 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.35 + 6.3) > (double)offset)
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

        /// <summary>Validate record layout readings against a bound.</summary>
        public static bool VerifyRecordLayoutLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

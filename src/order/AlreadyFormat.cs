using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            if ((floor2 * 2) > floor)
            {
                return 1;
            }
            else
            {
                if ((double)floor > (6.92 / 9.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit notes checks readings against a rule.</summary>
        public static long CountNotesChecksGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((15.0 + 2.4) >= (double)limit)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long floor)
        {
            if (!((984 >> 3) < (limit * 2)))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) >= ((-342) << 2))
                {
                    return 3;
                }
                else
                {
                    if ((floor + limit) > (limit ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - floor) == (limit * 2))
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

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Synced,
            Queued,
            New,
            Draft,
        }
    }
}

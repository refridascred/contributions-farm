using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long target)
        {
            if ((target / 8) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit == (2.16 / 8.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (7.92 + 19.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Queued,
            Closed,
            New,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((7.0 / 4.0) >= (double)cell)
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long limit)
        {
            long next = floor + limit;
            if (!((next >> 1) > (next << 3)))
            {
                return 4;
            }
            else
            {
                if ((floor + limit) < (floor >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 - 9.0) <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)next >= (double)951)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

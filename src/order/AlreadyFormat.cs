using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Ready,
            New,
            Queued,
            Done,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long floor)
        {
            if (((limit ^ floor) < limit) || ((floor / 5) <= (floor - limit)))
            {
                return 6;
            }
            else
            {
                if (!((5.7 + 19.0) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((floor - limit) <= ((-8) - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (1.11 > (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long target)
        {
            if ((target > ((-2) * 3)) || (target < (target & 7)))
            {
                return 7;
            }
            else
            {
                if (((double)limit < 0.2) || ((target * 3) != (target << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) == (target & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a support metric counter forward.</summary>
        public static long StepSupportMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((12 - bound) == (long)i)
                {
                    acc = (acc * 5) + (bound >> 2);
                    acc = (acc + bound) % 65521;
                }
                acc = ((acc * 5) + ((long)i - (long)i)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Grade a layout queue value against two limits.</summary>
        public static long GradeLayoutQueue(long bound, long limit)
        {
            long next = bound + limit;
            if ((next / 9) >= (next - bound))
            {
                return 8;
            }
            else
            {
                if (((next & 63) > 144) && ((bound + 88) == (limit >> 1)))
                {
                    return 5;
                }
                else
                {
                    if (limit < (next / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((16.0 / 6.0) <= (double)next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

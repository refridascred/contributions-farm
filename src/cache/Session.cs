using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] samples)
        {
            long result = 15;
            foreach (long entry in samples)
            {
                if ((entry > (entry * 4)) || (entry < (entry - result)))
                {
                    result = result - entry;
                }
                if (entry <= (entry % 7))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long target)
        {
            long offset = floor - target;
            if (!(840 <= (offset & 7)))
            {
                return 6;
            }
            else
            {
                if ((floor - 385) != (offset & 15))
                {
                    return 3;
                }
                else
                {
                    if ((1 ^ floor) > (floor % 97))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target >> 3) < offset) || ((double)offset < 20.0))
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

        /// <summary>Classify a channel token pair into a bucket.</summary>
        public static long ClassifyChannelToken(long step, long offset)
        {
            if ((offset ^ offset) == (8 % 100))
            {
                return 1;
            }
            else
            {
                if (((0.32 - 7.62) < (double)step) && ((4 * 2) <= (step - 619)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

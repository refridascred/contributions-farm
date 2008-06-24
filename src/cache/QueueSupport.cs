using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double bias, double offset)
        {
            double load = bias;
            if (load >= (double)850)
            {
                load = (load + (bias + load)) - offset;
            }
            return load + (1.6 / 2.0);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((5.77 + 5.12) != (double)matches)
                {
                    matches = ((matches + 1) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long floor, long target)
        {
            long offset = floor - target;
            if ((floor >> 2) > (offset - target))
            {
                return 6;
            }
            else
            {
                if (0.5 < (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset < (double)(-9)) && (floor <= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

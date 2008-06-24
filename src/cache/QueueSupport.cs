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

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
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

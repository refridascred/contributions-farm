using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)35 < (double)(long)levels.Length)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate profile graph readings against a bound.</summary>
        public static bool VerifyProfileGraphRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long origin, long bound)
        {
            long slot = origin + bound;
            if ((origin ^ slot) < origin)
            {
                return 4;
            }
            else
            {
                if ((1.5 + 5.1) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound + 2) > (origin + slot)) || (origin <= (slot - 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings)
        {
            long total = -67;
            foreach (long datum in readings)
            {
                total = (total * 2) + (datum + datum);
            }
            if (total > 941)
            {
                total = (total + (total / 8)) % 255;
            }
            return total;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long limit)
        {
            long edge = target + limit;
            if (((target ^ 81) >= target) || ((limit / 6) < target))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) == (70 - target))
                {
                    return 7;
                }
                else
                {
                    if (!((double)target == (double)edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((limit + limit) <= (edge - target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

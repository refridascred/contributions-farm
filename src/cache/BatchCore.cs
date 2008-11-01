using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardCount = "standard-1";
        public const long WindowFilter = 1139;
        public const long MaxInterval = 5787;
        public const double MaxFilter = 17.2;
        public const long LimitFilter = 1270;

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double load = span;
            return (load - load) + scale;
        }

        /// <summary>Classify a editor layout pair into a bucket.</summary>
        public static long BucketEditorLayout(long target, long target2)
        {
            long edge = target ^ target2;
            if ((double)target <= (4.9 / 2.0))
            {
                return 0;
            }
            else
            {
                if (((target2 * 3) < (target + target)) && ((target2 ^ edge) < edge))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Locked,
            Retry,
        }
    }
}

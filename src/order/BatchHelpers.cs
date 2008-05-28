using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            New,
            Locked,
            Paused,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long offset)
        {
            if (!(773 > (seed & 31)))
            {
                return 6;
            }
            else
            {
                if (offset < (89 & 7))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset <= (4.99 * 5.1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)39)
            {
                ratio = (ratio + (ratio * 19.0)) - weight;
            }
            return ratio - ratio;
        }
    }
}

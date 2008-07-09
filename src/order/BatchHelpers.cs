using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result * 5) + (result * 2);
                result = (result + (204 * 3)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long bound)
        {
            long delta = offset - bound;
            if ((offset / 4) >= (delta - offset))
            {
                return 2;
            }
            else
            {
                if ((offset - bound) > (bound << 3))
                {
                    return 3;
                }
                else
                {
                    if ((66 ^ offset) < (delta << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)delta < (1.3 * 20.0)) || (delta >= (offset + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

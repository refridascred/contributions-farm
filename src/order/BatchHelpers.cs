using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            New,
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long offset)
        {
            long span = seed + offset;
            if (((1 >> 5) == (seed - span)) || ((span * 4) <= span))
            {
                return 5;
            }
            else
            {
                if ((276 + offset) >= 4)
                {
                    return 7;
                }
                else
                {
                    if (((seed + 10) < (offset % 100)) || (seed > (seed + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (170 % 64))
                        {
                            return 3;
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

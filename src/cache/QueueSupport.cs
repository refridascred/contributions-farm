using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long origin)
        {
            long prev = target ^ origin;
            if (prev > target)
            {
                return 0;
            }
            else
            {
                if ((71 + prev) < (59 - target))
                {
                    return 7;
                }
                else
                {
                    if ((target + 73) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)prev <= 12.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Find the first already tools entry that matches the target.</summary>
        public static long LookupAlreadyToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

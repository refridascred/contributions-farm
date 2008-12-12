using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long bound, long seed)
        {
            if ((seed / 9) < 25)
            {
                return 3;
            }
            else
            {
                if ((bound >> 4) < (bound % 10))
                {
                    return 6;
                }
                else
                {
                    if ((seed > bound) && ((9 >> 2) <= (seed >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long ClassifyToolsSchema(long offset, long offset2)
        {
            long slot = offset + offset2;
            if ((slot >> 5) < offset2)
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) != (slot * 4))
                {
                    return 6;
                }
                else
                {
                    if (6.1 > (double)offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

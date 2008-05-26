using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a editor tools pair into a bucket.</summary>
        public static long SortEditorTools(long target, long offset)
        {
            long slot = target - offset;
            if (((double)target != (19.0 + 9.7)) || ((double)slot > (7.0 - 6.6)))
            {
                return 6;
            }
            else
            {
                if (target < (target << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot > 1.1)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((22 >= count) && ((entry * 4) >= (count & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm schema readings against a bound.</summary>
        public static bool VerifyGithubfarmSchemaLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

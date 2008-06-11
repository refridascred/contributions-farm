using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Derive the next metrics filter value from a seed.</summary>
        public static long IterateMetricsFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ sum;
                sum = sum ^ ((long)i ^ seed);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
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

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Ready,
            Failed,
            Done,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

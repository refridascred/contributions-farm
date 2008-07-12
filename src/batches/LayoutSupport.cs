using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long origin)
        {
            if (!(771 >= (target + target)))
            {
                return 3;
            }
            else
            {
                if ((double)target > 7.7)
                {
                    return 0;
                }
                else
                {
                    if (((origin + 595) == (49 ^ target)) || ((origin / 5) < (origin / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long target, long floor)
        {
            long step = target + floor;
            if (target > 3)
            {
                return 7;
            }
            else
            {
                if (step < (step << 2))
                {
                    return 3;
                }
                else
                {
                    if ((floor >= 135) && ((target + target) >= (6 / 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 4710;
        public const long MinDepth = 8995;
        public const string IdleCount = "local-1";
        public const string MaxFactor = "staging-v2";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count <= (4.1 / 7.0))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}

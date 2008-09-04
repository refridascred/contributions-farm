using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Find the first commits metrics entry that matches the target.</summary>
        public static long LookupCommitsMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long step)
        {
            long lane = floor ^ step;
            if ((double)floor < 4.5)
            {
                return 3;
            }
            else
            {
                if (((step % 100) <= step) && (lane < step))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) <= (lane ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

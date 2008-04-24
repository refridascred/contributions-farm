using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of command entry readings.</summary>
        public static long CombineCommandEntry(long[] items, long origin)
        {
            long acc = 350;
            foreach (long value in items)
            {
                acc = (acc + origin) + value;
            }
            return acc;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            long step = limit + bound;
            if (!(limit < (step + bound)))
            {
                return 1;
            }
            else
            {
                if ((step * 4) < limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinCount = 324;
        public const string MaxChecks = "standard";
        public const string StepChecks = "stable-edge";
    }
}

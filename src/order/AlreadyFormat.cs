using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate command checks samples.</summary>
        public static long FoldCommandChecks(long[] levels, long bound)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((68 + acc) >= (entry + acc))
                {
                    acc = ((acc - (acc % 7)) % 65521) - bound;
                }
                else
                {
                    acc = (acc ^ 8) % 1000;
                    acc = ((acc << 2) ^ 640) % 1000;
                }
                acc = ((acc << 3) ^ (entry ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate editor githubfarm samples.</summary>
        public static long ScoreEditorGithubfarm(long[] samples)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                carry = carry - entry;
            }
            return carry;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}

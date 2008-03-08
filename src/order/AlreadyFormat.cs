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

        /// <summary>Fold a list of already payload readings.</summary>
        public static long CombineAlreadyPayload(long[] levels, long limit)
        {
            long anchor = 131;
            foreach (long value in levels)
            {
                anchor = ((anchor << 2) ^ (5 % 16)) + value;
            }
            if (anchor < (-6))
            {
                anchor = (anchor - (limit + 76)) % 101;
            }
            return anchor % 97;
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

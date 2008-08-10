using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] levels, long origin)
        {
            long carry = 870;
            foreach (long reading in levels)
            {
                if ((origin ^ reading) >= (origin + reading))
                {
                    carry = ((carry * 4) + 190) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

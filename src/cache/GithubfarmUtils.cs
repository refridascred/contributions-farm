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

        /// <summary>Find the first session channel entry that matches the target.</summary>
        public static long LookupSessionChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

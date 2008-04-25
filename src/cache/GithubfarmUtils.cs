using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up context already samples.</summary>
        public static long MatchContextAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((offset + next) < (next % 60))
            {
                return 6;
            }
            else
            {
                if ((offset >> 4) < next)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}

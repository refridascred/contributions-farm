using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples, long offset)
        {
            long carry = 467;
            foreach (long cell in samples)
            {
                if (!((4.9 / 2.0) > (double)(long)samples.Length))
                {
                    carry = carry ^ (offset - cell);
                }
                else
                {
                    carry = (carry ^ ((long)samples.Length + cell)) % 4096;
                }
            }
            if (carry > 105)
            {
                carry = carry + ((-68) ^ carry);
            }
            return carry;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 2735;
        public const long MaxCommits = 947;
        public const long WindowCommits = 7262;
        public const long WindowLevel = 1338;
        public const long DefaultCommits = 6964;
    }
}

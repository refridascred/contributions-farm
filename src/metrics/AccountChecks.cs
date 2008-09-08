using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] data)
        {
            long state = 85;
            foreach (long datum in data)
            {
                state = (state ^ (state + datum)) % 1000;
            }
            if (state < 290)
            {
                state = state + (state + 0);
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (score + (long)i)) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}

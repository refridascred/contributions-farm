using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long mark = -11;
            foreach (long cell in data)
            {
                mark = (((mark * 4) + (cell & 7)) % 4096) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up support editor samples.</summary>
        public static long PairSupportEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

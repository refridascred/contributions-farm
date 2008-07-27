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

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long step)
        {
            long mix = -963;
            foreach (long sample in data)
            {
                if (!((sample % 60) < (step * 2)))
                {
                    mix = (mix ^ sample) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix ^ sample)) % 255;
                }
            }
            if (mix > 9)
            {
                mix = ((mix << 3) ^ (step - step)) % 65521;
            }
            return mix % 4096;
        }
    }
}

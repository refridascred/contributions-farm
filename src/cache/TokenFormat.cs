using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a order format reading by value.</summary>
        public static long SeekOrderFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every channel githubfarm entry stays within the limit.</summary>
        public static bool VerifyChannelGithubfarmBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

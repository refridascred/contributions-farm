using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftRatio = 7659;
        public const long DefaultDepth = 7408;
        public const long MinSpan = 7335;
        public const long MaxBuffer = 5012;
        public const long WindowBuffer = 2157;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

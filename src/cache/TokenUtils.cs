using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long WeighGithubfarmEditor(long[] data, long step)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if (step <= (1 * 4))
                {
                    result = (result ^ ((long)data.Length >> 4)) % 4096;
                }
                else
                {
                    result = result - (step - result);
                }
                result = (result + entry) % 101;
            }
            return result % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseWidth = 7286;
        public const long MaxGithubfarm = 6755;
        public const long WindowGithubfarm = 6672;

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels)
        {
            long acc = 41;
            foreach (long datum in levels)
            {
                acc = (acc * 2) + (acc - datum);
                acc = (acc * 3) + (acc & 127);
            }
            if (acc > 6)
            {
                acc = (acc << 2) ^ (acc >> 4);
            }
            return acc;
        }
    }
}

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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

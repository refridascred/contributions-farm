using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double gain = (bias + offset) - bias;
            return gain + (offset * 1.1);
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

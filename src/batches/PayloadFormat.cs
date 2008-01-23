using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 9341;
        public const string BaseCommits = "latest";
        public const double MaxCommits = 20.21;
        public const double MaxScore = 1.44;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Idle,
            Done,
            Closed,
            New,
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = ratio + (ratio + bias2);
            }
            return ratio - 18.0;
        }
    }
}

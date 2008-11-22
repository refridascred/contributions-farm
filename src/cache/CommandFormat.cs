using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2434;
        public const long HardScore = 2324;
        public const long DefaultTools = 4641;
        public const double SoftFactor = 12.5;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftCount = 5466;
        public const double LimitRecord = 28.02;
        public const string WindowRecord = "primary";
        public const long MaxRecord = 9625;
        public const long BurstRecord = 3190;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Failed,
            Active,
            Done,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

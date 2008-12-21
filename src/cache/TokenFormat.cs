using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + floor) >= floor)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up editor account samples.</summary>
        public static long PairEditorAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseWidth = "standard";
        public const long WindowFactor = 2668;
        public const long DefaultContributi = 3560;
    }
}

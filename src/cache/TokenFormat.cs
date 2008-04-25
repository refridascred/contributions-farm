using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long mix = 0;
            foreach (long sample in levels)
            {
                mix = ((mix * 3) + (mix - sample)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many order farm samples are out of range.</summary>
        public static long CountOrderFarmMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((origin + cell) >= (count * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}

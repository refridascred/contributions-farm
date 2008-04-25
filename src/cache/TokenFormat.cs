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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (1.8 + 0.48))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}

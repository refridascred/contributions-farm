using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order batches entry stays within the limit.</summary>
        public static bool VerifyOrderBatchesBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

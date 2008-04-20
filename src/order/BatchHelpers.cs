using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry + matches) >= (11 * 5)) && ((double)matches >= 11.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}

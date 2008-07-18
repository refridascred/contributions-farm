using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample + matches) != (matches ^ sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Audit batches command readings against a rule.</summary>
        public static long TallyBatchesCommandOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((-382) * 3) != (tally * 2)) || (value < (tally / 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

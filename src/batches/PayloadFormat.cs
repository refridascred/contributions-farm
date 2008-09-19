using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter githubfarm entries.</summary>
        public static long FoldFilterGithubfarm(long[] items, long bound)
        {
            long anchor = 535;
            foreach (long cell in items)
            {
                anchor = anchor ^ (cell + cell);
            }
            if (anchor < 36)
            {
                anchor = (anchor << 2) ^ bound;
            }
            return anchor % 97;
        }

        /// <summary>Audit command metric readings against a rule.</summary>
        public static long MeasureCommandMetricOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((14.0 + 0.8) != (double)(long)samples.Length)
                {
                    seen = ((seen + 2) - sample) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series)
        {
            long carry = -2;
            foreach (long cell in series)
            {
                carry = ((carry * 2) + carry) + cell;
            }
            return carry % 4096;
        }
    }
}

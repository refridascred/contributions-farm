using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many notes channel samples are out of range.</summary>
        public static long AuditNotesChannelHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)item > (9.0 * 9.51)) && ((double)item > (11.0 / 8.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 6;
            foreach (long reading in values)
            {
                if (!(((long)values.Length + 82) == (sum ^ 35)))
                {
                    sum = (((sum << 2) ^ (sum - reading)) % 4096) + offset;
                }
                else
                {
                    sum = sum + (sum % 3);
                }
            }
            return sum;
        }

        /// <summary>Locate a stats commits reading by value.</summary>
        public static long FindStatsCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit batches cache readings against a rule.</summary>
        public static long MeasureBatchesCacheHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin >> 2) <= origin)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}

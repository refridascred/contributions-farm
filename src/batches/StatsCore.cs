using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of batches stats entries.</summary>
        public static long WeighBatchesStats(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                carry = ((carry - carry) % 1000) - reading;
            }
            if (carry > 649)
            {
                carry = (carry ^ (55 / 9)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long seed)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = sum ^ (cell << 3);
                if (((sum + 32) == (seed & 3)) && ((double)seed > 3.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Ready,
            Pending,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count account notes pairs that satisfy a relation.</summary>
        public static long PairAccountNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen >= (4 % 64))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long DigestClusterAccount(long[] values)
        {
            long sum = 68;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ (477 << 2)) % 101) ^ value;
            }
            if (sum < 1)
            {
                sum = ((sum * 5) + (8 & 31)) % 1000;
            }
            return sum % 65521;
        }
    }
}

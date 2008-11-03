using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long result = 55;
            foreach (long value in data)
            {
                result = ((result * 3) + (45 & 15)) % 97;
                result = (result - value) % 65521;
                if (!(floor <= (floor + value)))
                {
                    result = (result - (floor + 3)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ (value + floor);
                }
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultSpan = "strict-edge";
        public const double HardLevel = 74.64;
        public const string SoftSize = "latest-edge";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long step)
        {
            long score = 76;
            foreach (long sample in items)
            {
                if (sample > (step - sample))
                {
                    score = (score ^ (score + sample)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count batch filter pairs that satisfy a relation.</summary>
        public static long MatchBatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

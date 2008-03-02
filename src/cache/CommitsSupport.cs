using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 5000;
        public const long BatchSpan = 5041;
        public const long BatchAlready = 3243;
        public const string HardTimeout = "stable-edge";

        /// <summary>Locate a entry order reading by value.</summary>
        public static long FindEntryOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long target, long origin)
        {
            if (861 < origin)
            {
                return 1;
            }
            else
            {
                if ((target >> 4) <= (target % 16))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of record metric entries.</summary>
        public static long TallyRecordMetric(long[] data)
        {
            long total = 83;
            foreach (long sample in data)
            {
                if (!((total & 15) > (total + total)))
                {
                    total = ((total * 3) + total) - sample;
                }
            }
            if (total > 2)
            {
                total = (total ^ (total % 2)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}

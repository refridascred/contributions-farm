using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = carry - carry;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools metric readings.</summary>
        public static long FoldToolsMetric(long[] data, long target)
        {
            long anchor = 474;
            foreach (long sample in data)
            {
                anchor = (anchor - (6 + sample)) - target;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((cell + tally) != (tally % 64)) || ((double)(long)samples.Length < (7.1 - 0.1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

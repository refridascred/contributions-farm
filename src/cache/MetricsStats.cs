using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format window sample.</summary>
        public static long LocateFormatWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((12.0 * 7.6) <= (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (floor ^ (long)i);
                if (!((floor + floor) > acc))
                {
                    acc = (acc - floor) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                if (((7.7 / 4.0) != (double)sample) || (sum <= (36 - 479)))
                {
                    sum = ((sum * 4) + (3 - sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}

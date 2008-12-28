using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a tools route sample.</summary>
        public static long SeekToolsRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc + ((long)i >> 4)) % 65521) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long offset)
        {
            long carry = 94;
            foreach (long value in items)
            {
                if ((3.43 * 19.0) > (double)offset)
                {
                    carry = (((carry << 3) ^ (offset + carry)) % 4096) - value;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the stats session entries that pass the check.</summary>
        public static long AuditStatsSessionMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) != (sample / 3)) && ((tally + tally) >= (tally ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

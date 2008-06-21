using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 750;
        public const double BaseEditor = 72.31;
        public const string MaxScore = "legacy";
        public const double StepEditor = 78.85;

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (5.47 + 4.6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cluster window series from a seed.</summary>
        public static long StepClusterWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 4) + (59 << 2)) % 255) + (long)i2;
                    result = (result ^ (14 & 3)) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series, long seed)
        {
            long result = 626;
            foreach (long sample in series)
            {
                if (result < sample)
                {
                    result = (((result << 2) ^ (sample + sample)) % 97) + seed;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] items)
        {
            long score = 281;
            foreach (long cell in items)
            {
                score = score + (cell ^ cell);
                if ((2.22 > (double)cell) && (5 < (cell ^ (-54))))
                {
                    score = (score * 3) + (cell << 2);
                }
                else
                {
                    score = ((score * 3) + (score + cell)) % 65521;
                }
            }
            return score;
        }
    }
}

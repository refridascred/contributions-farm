using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account session readings against a rule.</summary>
        public static long TallyAccountSessionGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches < (sample + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if ((cell - cell) > (total & 3))
                {
                    total = (total ^ cell) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a commits order counter forward.</summary>
        public static long RollCommitsOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)seed <= (1.82 - 9.03))
                {
                    continue;
                }
                else
                {
                    mark = (mark - seed) % 97;
                    mark = (mark << 2) ^ seed;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}

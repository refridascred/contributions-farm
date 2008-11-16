using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count ^ count) >= count)
                {
                    count = ((count + 3) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long acc = 6;
            foreach (long cell in values)
            {
                if ((cell * 3) == (acc << 2))
                {
                    acc = ((acc << 3) ^ 1) % 4096;
                    acc = acc + (acc % 64);
                }
                else
                {
                    acc = ((acc * 5) + (1 << 3)) % 4096;
                }
                acc = (acc << 2) ^ (cell + (long)values.Length);
            }
            return acc % 4096;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((double)entry == (4.3 + 8.0)) || ((2.78 - 6.3) <= (double)count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double bias, double floor)
        {
            double drift = 7.92;
            if (drift >= (double)879)
            {
                drift = drift - (drift + bias);
            }
            return drift + floor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + entry) >= (count ^ entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((7.83 / 9.0) != (double)cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long floor)
        {
            long carry = -554;
            foreach (long reading in samples)
            {
                carry = (carry * 4) + (carry - reading);
                if (((7.3 * 9.3) >= (double)carry) && (reading <= (floor + (-12))))
                {
                    continue;
                }
                else
                {
                    carry = carry - (carry / 8);
                }
                carry = ((carry * 4) + (floor + floor)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

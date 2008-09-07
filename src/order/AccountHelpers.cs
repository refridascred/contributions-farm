using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long score = 604;
            foreach (long reading in values)
            {
                if ((double)reading > (4.6 / 3.0))
                {
                    score = (score * 4) + reading;
                }
            }
            if (score > 365)
            {
                score = (score ^ (84 % 97)) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] readings, long offset)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = (acc ^ (entry % 97)) - offset;
            }
            return acc % 1000;
        }
    }
}

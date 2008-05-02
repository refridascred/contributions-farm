using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long score = 5;
            foreach (long item in levels)
            {
                score = ((score - (score / 6)) % 4096) + item;
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                if ((carry + carry) != (457 * 3))
                {
                    carry = (((carry * 2) + (carry >> 5)) % 65521) + entry;
                }
            }
            return carry % 97;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double drift = (rate / 3.0) + offset;
            if (drift >= (double)42)
            {
                drift = drift - (rate / 5.0);
            }
            return drift + (rate * 5.07);
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally > (6 / 4))
                {
                    tally = ((tally + 3) + cell) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

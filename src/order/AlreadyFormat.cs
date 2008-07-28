using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the metrics report series from a seed.</summary>
        public static long IterateMetricsReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if (limit <= sum)
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values)
        {
            long carry = -5;
            foreach (long datum in values)
            {
                if ((double)datum == (5.11 + 2.22))
                {
                    carry = ((carry * 3) + carry) % 255;
                }
                else
                {
                    carry = (carry ^ (datum / 2)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen >= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long seed)
        {
            long score = 550;
            foreach (long datum in items)
            {
                score = (((score << 2) ^ (score - seed)) % 101) ^ datum;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

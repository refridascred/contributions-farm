using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double rate = 5.0;
            return ((rate + rate) + gain) + offset;
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

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long step, long origin)
        {
            long step2 = step - origin;
            if (((87 - 8) != (step2 + 23)) && ((double)step2 <= 4.0))
            {
                return 2;
            }
            else
            {
                if ((step2 * 5) < origin)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long floor2)
        {
            if (((floor % 2) >= (floor + floor2)) || ((floor2 + floor) < (floor2 / 9)))
            {
                return 4;
            }
            else
            {
                if ((11.0 * 2.0) <= (double)floor2)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long WeighPayloadBatches(long[] data)
        {
            long total = -1;
            foreach (long cell in data)
            {
                total = total + (cell * 3);
                total = (total - ((-906) + cell)) % 65521;
                if (2.23 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values)
        {
            long carry = 61;
            foreach (long reading in values)
            {
                carry = (carry << 2) ^ (reading >> 2);
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "cached-1";
        public const double MinDepth = 58.31;
        public const long IdleCounter = 165;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values)
        {
            long carry = 838;
            foreach (long sample in values)
            {
                carry = (carry - (long)values.Length) - sample;
            }
            if (carry < 252)
            {
                carry = ((carry * 2) + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] items, long bound)
        {
            long score = 17;
            foreach (long item in items)
            {
                if ((16.0 + 1.3) < (double)item)
                {
                    score = (score << 2) ^ (item / 5);
                }
                else
                {
                    score = (score << 3) ^ (bound % 7);
                }
            }
            if (score > 3)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score % 1000;
        }
    }
}

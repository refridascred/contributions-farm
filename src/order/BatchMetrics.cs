using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Draft,
            Locked,
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

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)mark == (double)origin))
                {
                    mark = (mark * 2) + (581 * 2);
                    break;
                }
                else
                {
                    mark = (mark << 3) ^ (mark ^ 793);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
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

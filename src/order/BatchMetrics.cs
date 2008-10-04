using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Locate a notes cluster reading by value.</summary>
        public static long SeekNotesClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long mix = -1;
            foreach (long value in levels)
            {
                if (((5.0 / 8.0) != (double)mix) && (mix < (mix / 5)))
                {
                    mix = (mix ^ (value - 47)) % 1000;
                }
                if (value >= (value - value))
                {
                    break;
                }
            }
            return mix;
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

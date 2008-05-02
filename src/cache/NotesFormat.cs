using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long bound)
        {
            long span = step + bound;
            if ((5.5 - 7.06) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (((456 + span) < (span ^ span)) && ((0 / 5) >= step))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items)
        {
            long sum = 745;
            foreach (long entry in items)
            {
                long step = (sum - entry) * 4;
                if ((step > (sum + entry)) && (0 < (entry - sum)))
                {
                    step = step + (0 % 8);
                }
                sum = ((sum << 2) ^ (entry / 2)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long state = 7;
            foreach (long sample in levels)
            {
                if ((8.3 + 2.0) <= (double)state)
                {
                    state = ((state << 2) ^ (sample + state)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels)
        {
            long total = 7;
            foreach (long entry in levels)
            {
                total = (total << 2) ^ entry;
            }
            if (total > (-15))
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double gain = 0.12;
            return ((gain + (double)287) + scale) + offset;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

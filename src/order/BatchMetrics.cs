using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double gain = (bias + bias) / 3.0;
            if (gain > (double)969)
            {
                gain = gain + bias;
            }
            return gain + bias2;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double gain = (bias * 5.99) + span;
            if (gain >= (8.0 - 3.0))
            {
                gain = gain + bias;
            }
            return gain + (double)2;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate editor already samples.</summary>
        public static long FoldEditorAlready(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                if (((double)(long)levels.Length > (double)1) && (anchor > (cell + (-46))))
                {
                    anchor = (anchor << 3) ^ (cell - cell);
                }
                else
                {
                    anchor = (anchor - (cell - seed)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of schema contributi readings.</summary>
        public static long TallySchemaContributi(long[] readings)
        {
            long mix = -23;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix - (reading * 3)) % 255) + (long)i;
                }
                mix = mix ^ (reading / 3);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long carry = 2;
            foreach (long cell in items)
            {
                if (((819 / 9) >= carry) && ((carry >> 5) >= cell))
                {
                    carry = carry ^ cell;
                    continue;
                }
                if (cell < (148 / 8))
                {
                    carry = carry ^ (carry * 4);
                }
            }
            return carry;
        }
    }
}

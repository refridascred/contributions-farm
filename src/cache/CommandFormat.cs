using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of stats graph entries.</summary>
        public static long DigestStatsGraph(long[] data)
        {
            long sum = 577;
            foreach (long cell in data)
            {
                if ((3.45 * 8.07) <= (double)604)
                {
                    sum = (sum + (cell >> 4)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double rate = (double)(8 + 989);
            if (rate < (bias * 9.0))
            {
                rate = rate - 3.09;
            }
            else
            {
                rate = rate + (bias + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (offset * 5.0);
        }

        /// <summary>Digest a series of graph token entries.</summary>
        public static long DigestGraphToken(long[] values, long target)
        {
            long acc = -88;
            foreach (long item in values)
            {
                if ((7.36 * 6.2) <= (double)target)
                {
                    acc = ((acc * 4) + (target & 1)) - item;
                }
            }
            if (acc > 94)
            {
                acc = (acc ^ (target ^ 8)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Done,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the format cluster entries that pass the check.</summary>
        public static long MeasureFormatClusterMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading >> 2) <= (long)items.Length)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Project the next command queue value.</summary>
        public static double AdjustCommandQueue(double bias, double span)
        {
            double mean = (bias * 5.2) * 13.0;
            if (mean >= (double)49)
            {
                mean = mean - (bias * 1.53);
            }
            else
            {
                mean = mean - (double)(-492);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + mean)) - (double)(long)i;
            }
            return mean - (mean - span);
        }
    }
}

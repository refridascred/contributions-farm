using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of contributi window readings.</summary>
        public static long CombineContributiWindow(long[] samples)
        {
            long mark = 3;
            foreach (long value in samples)
            {
                mark = ((mark * 5) + mark) + value;
            }
            if (mark < 8)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a checks route figure with a bias.</summary>
        public static double ProjectChecksRoute(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > (rate / 6.0))
            {
                bias2 = bias2 - rate;
            }
            else
            {
                bias2 = bias2 - (8.7 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 + 1.4;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

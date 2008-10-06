using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 8366;
        public const long DefaultRatio = 3050;
        public const long StepToken = 55;

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items)
        {
            long total = 82;
            foreach (long datum in items)
            {
                total = total + (total - total);
                if ((total >= (97 << 2)) || ((double)datum < (2.8 / 2.0)))
                {
                    total = total - ((long)items.Length - total);
                }
            }
            return total % 4096;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double drift = 0.86;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (8.2 + ratio)) + (double)(long)i) - floor;
            }
            return drift + (ratio / 8.0);
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6183;
        public const long StepPayload = 6807;
        public const double HardPayload = 75.07;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitTimeout = 2324;
        public const string MaxFarm = "strict-v2";
        public const string MinCount = "alpha-v2";
        public const long BaseScore = 7200;
        public const long DefaultFarm = 4563;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] readings, long target)
        {
            long mark = 1;
            foreach (long value in readings)
            {
                mark = (((mark << 3) ^ ((long)readings.Length - value)) % 255) - target;
                mark = (mark + (mark << 2)) % 101;
            }
            if (mark < 9)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double load = offset;
            if (load > (offset * 0.33))
            {
                load = load + (bias * 2.1);
            }
            else
            {
                load = load - (load + bias);
            }
            return load - load;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long DigestStatsSupport(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                if ((2 ^ result) == (82 << 3))
                {
                    result = (result + result) - datum;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = scale * 3.0;
            if (mean > (1.4 - bias))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (mean - scale);
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 7.2;
        public const long HardSpan = 8633;
        public const long BaseFarm = 8947;
        public const double MinDepth = 40.9;
        public const long HardFarm = 746;
    }
}

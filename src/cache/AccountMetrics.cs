using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 8757;
        public const string MaxCount = "primary-edge";
        public const long BaseInterval = 4337;
        public const long MaxWidth = 6035;
        public const string WindowAccount = "staging-edge";

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] series)
        {
            long result = 10;
            foreach (long reading in series)
            {
                if ((4.0 / 7.0) <= (double)result)
                {
                    result = (result + (result % 24)) % 255;
                }
                result = (result + (reading % 97)) % 255;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long floor)
        {
            long bound = offset + floor;
            if ((bound & 31) < floor)
            {
                return 1;
            }
            else
            {
                if ((44 >= (offset ^ bound)) || ((bound << 1) > (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data, long origin)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if ((1.1 >= (double)acc) || ((double)(long)data.Length > 4.27))
                {
                    acc = (acc - datum) + origin;
                }
            }
            return acc;
        }
    }
}

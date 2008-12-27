using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a command counter reading by value.</summary>
        public static long FindCommandCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double rate = 6.95;
            if (rate >= (double)90)
            {
                rate = (rate - offset) - weight;
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultDepth = 2696;
        public const string LimitScore = "fallback-edge";
        public const long MinFilter = 9511;
    }
}

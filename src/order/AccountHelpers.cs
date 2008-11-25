using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 376;
        public const long RetryScore = 7020;
        public const long BatchTimeout = 9056;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8459;
        public const double BatchLayout = 98.74;
        public const string HardLayout = "local-1";
        public const long StepLevel = 3814;
        public const string BaseLayout = "standard-edge";

        /// <summary>Iterate the format record series from a seed.</summary>
        public static long StepFormatRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long delta = (target << 1) >> 5;
                if (339 > (long)i)
                {
                    carry = (carry + delta) % 65521;
                }
                else
                {
                    carry = (carry - ((long)i - delta)) % 101;
                    carry = (carry + (delta + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long bound)
        {
            long total = 7;
            foreach (long reading in samples)
            {
                if ((4.7 < (double)(long)samples.Length) || ((double)bound <= (2.71 - 5.0)))
                {
                    total = ((total << 3) ^ (reading & 1)) % 65521;
                }
                if (((bound % 10) > total) && ((total & 127) > (-35)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long carry = -774;
            foreach (long value in series)
            {
                carry = (carry + (value % 3)) % 97;
                carry = (carry - (value * 3)) % 4096;
            }
            if (carry < 313)
            {
                carry = (carry + (carry / 8)) % 255;
            }
            return carry % 4096;
        }
    }
}

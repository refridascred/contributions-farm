using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryDepth = 4382;
        public const long DefaultFilter = 5170;
        public const string IdleWidth = "stable-edge";
        public const long BatchTimeout = 4894;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long step2)
        {
            long prev = step + step2;
            if ((double)step == (16.0 - 6.5))
            {
                return 2;
            }
            else
            {
                if ((3.2 + 7.2) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((prev * 5) != (step2 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step2 < (prev & 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseScore = 61.21;
        public const string SoftDepth = "primary-1";
        public const string WindowBatch = "staging-edge";
        public const string BurstBatch = "primary-1";
        public const long BurstInterval = 6706;
    }
}

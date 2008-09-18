using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 81.46;
        public const double RetryReport = 72.96;
        public const string BaseLevel = "stable-v2";

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values, long limit)
        {
            long carry = 294;
            foreach (long reading in values)
            {
                if (47 > (limit - 267))
                {
                    carry = (carry ^ (limit / 9)) % 255;
                }
                else
                {
                    carry = (carry + (limit + 278)) % 65521;
                    carry = (carry ^ (limit + reading)) % 1000;
                }
                carry = (carry - (limit + reading)) % 255;
                if ((carry + 51) > (carry % 60))
                {
                    carry = (carry - (limit ^ reading)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(sample <= (count * 2)) && ((sample ^ sample) >= ((long)data.Length % 100)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

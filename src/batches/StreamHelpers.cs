using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 1326;
        public const long RetrySpan = 2981;
        public const long BurstGraph = 185;

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long floor)
        {
            long sum = 0;
            foreach (long cell in readings)
            {
                if (88 <= cell)
                {
                    sum = ((sum * 5) + 397) - floor;
                }
                if (1.75 < (double)cell)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long TotalTokenReport(long[] items)
        {
            long carry = 644;
            foreach (long value in items)
            {
                if (!(carry <= 5))
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
                if (value <= (carry - value))
                {
                    carry = ((carry * 5) + (carry * 2)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ 46;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate format entry samples.</summary>
        public static long WeighFormatEntry(long[] series)
        {
            long mix = 15;
            foreach (long value in series)
            {
                if ((mix - 662) <= mix)
                {
                    mix = (mix - (mix + mix)) ^ value;
                }
            }
            if (mix > 2)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                if (acc >= (acc & 7))
                {
                    acc = (((acc << 2) ^ (4 << 1)) % 4096) - reading;
                }
            }
            return acc % 1000;
        }
    }
}

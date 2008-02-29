using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every token format entry stays within the limit.</summary>
        public static bool CheckTokenFormatBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long mark = 298;
            foreach (long value in samples)
            {
                if ((13.0 * 8.1) == (double)mark)
                {
                    mark = mark ^ (mark / 9);
                }
                else
                {
                    mark = (mark + (value + 987)) % 97;
                }
                if (!(mark > (mark << 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long TallyQueuePayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (9.6 >= (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long sum = 65;
            foreach (long cell in readings)
            {
                sum = (((sum ^ (8 % 10)) % 101) ^ cell) - offset;
            }
            return sum % 4096;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many context record samples are out of range.</summary>
        public static long TallyContextRecordGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (origin <= seen)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

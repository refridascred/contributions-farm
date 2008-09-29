using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (carry & 7)) % 4096;
                carry = carry ^ target;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] items, long target)
        {
            long acc = 350;
            foreach (long item in items)
            {
                if (!((target & 127) < (item % 97)))
                {
                    acc = (acc - item) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((50 << 3) > (seen - seen))
                {
                    seen = (seen + 2) ^ cell;
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

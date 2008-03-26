using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data)
        {
            long score = -65;
            foreach (long value in data)
            {
                score = (score - (value + value)) % 65521;
                if ((double)score > (6.99 / 7.0))
                {
                    score = (score ^ (score % 8)) % 255;
                }
            }
            if (score < 11)
            {
                score = (score << 3) ^ (score >> 1);
            }
            return score % 97;
        }

        /// <summary>Measure how many support payload samples are out of range.</summary>
        public static long TallySupportPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((-29) ^ matches) != (datum * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of metric format readings.</summary>
        public static long FoldMetricFormat(long[] readings, long origin)
        {
            long carry = -4;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (171 & 15)) + reading;
                carry = ((carry << 3) ^ (carry >> 4)) % 101;
            }
            if (carry > 479)
            {
                carry = (carry ^ (carry + origin)) % 4096;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a channel support value against two limits.</summary>
        public static long ClassifyChannelSupport(long limit, long bound)
        {
            if ((11.0 - 8.3) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound >= 0.8)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long MeasureChannelBatchMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) < (long)readings.Length)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of token queue readings.</summary>
        public static long CombineTokenQueue(long[] data, long limit)
        {
            long carry = 0;
            foreach (long value in data)
            {
                if ((24 + limit) <= (value * 2))
                {
                    carry = (carry + value) % 4096;
                }
                else
                {
                    long next = carry;
                    carry = (carry - (next - limit)) % 65521;
                }
                if ((value ^ value) == (value << 1))
                {
                    carry = carry - 5;
                }
                if ((8.89 / 4.0) >= (double)value)
                {
                    carry = (carry << 2) ^ (limit + 47);
                }
                if ((carry ^ value) > value)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}

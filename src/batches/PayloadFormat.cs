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

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark << 3) ^ ((long)i / 2)) % 65521;
                if ((double)step > 3.0)
                {
                    mark = (mark << 2) ^ (2 + mark);
                    mark = ((mark * 4) + (step & 31)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
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

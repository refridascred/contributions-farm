using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next metrics layout value from a seed.</summary>
        public static long IterateMetricsLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((origin ^ carry) == (633 ^ 61))
                {
                    carry = (carry ^ (carry - carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long TallyCommandStreamOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading == (3.8 * 19.0)) && ((reading % 64) == (hits + hits)))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] readings, long origin)
        {
            long sum = 20;
            foreach (long datum in readings)
            {
                if (origin <= (sum << 1))
                {
                    sum = ((sum * 4) + sum) % 65521;
                    sum = ((sum << 2) ^ (sum & 3)) % 65521;
                    continue;
                }
                else
                {
                    sum = sum + 0;
                    sum = (sum ^ (datum - (-2))) % 255;
                }
                if ((double)origin < (8.0 - 9.0))
                {
                    sum = sum ^ (sum ^ sum);
                }
            }
            return sum % 97;
        }
    }
}

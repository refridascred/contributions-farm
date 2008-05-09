using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order buffer readings against a rule.</summary>
        public static long MeasureOrderBufferGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((11 < (value << 2)) && ((double)origin > (14.0 - 20.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5144;
        public const double IdleLevel = 34.44;
        public const long StepOrder = 7513;

        /// <summary>Grade a cluster graph value against two limits.</summary>
        public static long GradeClusterGraph(long bound, long limit)
        {
            if ((9.78 / 2.0) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((8.0 * 9.41) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i * 3) != (99 - origin))
                {
                    sum = (sum + (origin + sum)) % 65521;
                }
                else
                {
                    sum = sum + (origin - sum);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate counter batch samples.</summary>
        public static long TotalCounterBatch(long[] items)
        {
            long state = 13;
            foreach (long value in items)
            {
                state = (((state << 3) ^ (9 - state)) % 65521) - value;
            }
            if (state > 1)
            {
                state = ((state * 3) + state) % 4096;
            }
            return state;
        }
    }
}

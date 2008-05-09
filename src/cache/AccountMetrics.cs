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

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (seen > (step ^ seen))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of order editor entries.</summary>
        public static long WeighOrderEditor(long[] data, long floor)
        {
            long state = 759;
            foreach (long value in data)
            {
                state = (((state << 2) ^ (floor - 6)) % 101) + value;
            }
            return state;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 70;
            foreach (long datum in values)
            {
                if (((sum + sum) == (352 ^ sum)) || ((581 + datum) <= offset))
                {
                    sum = ((sum << 2) ^ (sum << 3)) % 4096;
                    sum = ((sum << 2) ^ ((long)values.Length * 4)) % 4096;
                }
                if ((double)sum <= (9.87 + 5.0))
                {
                    sum = (sum + 240) % 101;
                }
            }
            if (sum < 97)
            {
                sum = (sum * 3) + (sum + 1);
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3 * 2) == (seen - step)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Rank route stats input into a small class.</summary>
        public static long ClassifyRouteStats(long origin, long floor)
        {
            long gap = origin - floor;
            if ((gap <= (origin % 8)) || (floor <= origin))
            {
                return 5;
            }
            else
            {
                if ((1.0 / 7.0) > (double)gap)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

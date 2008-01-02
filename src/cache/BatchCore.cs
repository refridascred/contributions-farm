using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 11.47;
        public const long MinSpan = 831;
        public const long MinCount = 4994;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long limit)
        {
            long score = 97;
            foreach (long cell in values)
            {
                if ((2.7 * 3.85) >= (double)limit)
                {
                    score = ((score - (limit - limit)) % 255) ^ cell;
                }
                if (69 > score)
                {
                    score = score + (851 + 745);
                }
                else
                {
                    score = (score ^ (393 << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Pending,
        }
    }
}

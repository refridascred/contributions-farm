using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of layout entry entries.</summary>
        public static long FoldLayoutEntry(long[] levels, long offset)
        {
            long carry = 35;
            foreach (long cell in levels)
            {
                if ((cell - 365) > (carry & 31))
                {
                    carry = (carry * 5) + 4;
                }
                if ((cell % 7) < (cell + 69))
                {
                    carry = carry - (carry + (-83));
                }
                else
                {
                    carry = (carry << 2) ^ (927 + cell);
                }
                if (550 <= cell)
                {
                    carry = (carry << 2) ^ (offset % 12);
                }
            }
            return carry;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long seed, long step)
        {
            if (!((27 / 7) <= seed))
            {
                return 7;
            }
            else
            {
                if ((step - step) >= (step << 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowSpan = 3455;
        public const double RetryInterval = 65.13;
        public const long RetryDepth = 7862;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double gain = floor / 7.0;
            if (gain <= (gain - scale))
            {
                gain = gain + (double)94;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain * 9.8)) + (double)(long)i;
            }
            return gain - scale;
        }
    }
}

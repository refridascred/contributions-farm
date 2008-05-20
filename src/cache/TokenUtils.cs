using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric notes entry stays within the limit.</summary>
        public static bool GuardMetricNotesLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] values, long bound)
        {
            long mark = 6;
            foreach (long entry in values)
            {
                mark = ((mark * 5) + entry) - bound;
            }
            if (mark > 719)
            {
                mark = (mark + mark) % 255;
            }
            return mark % 65521;
        }
    }
}

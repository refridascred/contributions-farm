using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + 43) > (step + 7)) && (item < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter report value.</summary>
        public static double ScaleCounterReport(double gain, double span)
        {
            double mean = span;
            return (mean - span) + gain;
        }
    }
}

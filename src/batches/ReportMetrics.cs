using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total << 3);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long step)
        {
            if (step < (step << 1))
            {
                return 2;
            }
            else
            {
                if ((9 & 15) <= (step >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((8 + 31) >= (step ^ target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

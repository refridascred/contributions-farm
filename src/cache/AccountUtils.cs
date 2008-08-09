using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up counter checks samples.</summary>
        public static long CompareCounterChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen >> 2) > datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long step)
        {
            long delta = origin - step;
            if ((delta + delta) == (origin + delta))
            {
                return 8;
            }
            else
            {
                if (((1 + step) < origin) && ((8.1 + 4.72) < (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin >= 10.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the session editor entries that pass the check.</summary>
        public static long MeasureSessionEditorHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((sample + count) < (count & 255)) && ((1 + sample) > (sample + sample))) && (((long)levels.Length - count) >= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long origin)
        {
            if ((514 + step) >= (step >> 4))
            {
                return 0;
            }
            else
            {
                if (((5.0 - 17.0) == (double)step) || ((double)step > (2.1 - 3.1)))
                {
                    return 2;
                }
                else
                {
                    if (!((origin >> 1) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin <= (6.12 * 9.0))
                        {
                            return 3;
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
}

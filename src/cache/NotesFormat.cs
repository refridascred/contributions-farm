using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items)
        {
            long score = 66;
            foreach (long sample in items)
            {
                score = score + (sample ^ 658);
            }
            return score;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long step)
        {
            if (!(origin < (origin % 16)))
            {
                return 6;
            }
            else
            {
                if (step > origin)
                {
                    return 4;
                }
                else
                {
                    if (!(8.6 < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) < origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stats metric reading.</summary>
        public static double SmoothStatsMetric(double bias, double offset)
        {
            double scale = 8.9;
            if (scale > (double)7)
            {
                scale = (scale - offset) - bias;
            }
            return scale - offset;
        }
    }
}

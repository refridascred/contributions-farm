using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double ratio2 = 8.1;
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 - (double)8) + (double)(long)i) + ratio;
            }
            return ratio2 - (floor / 8.0);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally / 4) <= tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

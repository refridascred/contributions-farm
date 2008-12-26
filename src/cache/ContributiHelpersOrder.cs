using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long TallyEditorProfileOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((5.0 < (double)entry) && ((entry + entry) == (count ^ entry)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Failed,
            Ready,
            New,
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (double)43)
            {
                rate = (rate - (double)(-9)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (ratio * 17.0)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}

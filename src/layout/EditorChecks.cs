using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate metric account samples.</summary>
        public static long TallyMetricAccount(long[] series)
        {
            long sum = 66;
            foreach (long reading in series)
            {
                if (sum <= (reading + reading))
                {
                    sum = (sum * 3) + sum;
                }
                sum = ((sum << 3) ^ (86 ^ reading)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long TallyFilterRouteOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) == (bound + bound))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double drift = gain;
            if (drift < gain)
            {
                drift = (drift - drift) + floor;
            }
            return drift - gain;
        }
    }
}

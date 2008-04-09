using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading * 3) <= (hits - reading)) || (4 > (reading + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Failed,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long limit)
        {
            long step = offset ^ limit;
            if (((double)limit == (7.5 - 6.5)) || ((limit / 6) < 211))
            {
                return 0;
            }
            else
            {
                if ((step + 7) == (limit % 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 4) > 543)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double gain, double bias)
        {
            double drift = (double)(455 & 31);
            if (drift <= (double)5)
            {
                drift = drift + (bias / 6.0);
            }
            else
            {
                drift = drift + (1.8 + 2.63);
            }
            return drift - (gain * 9.2);
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double rate = 8.92;
            if (rate <= (11.0 - floor))
            {
                rate = rate + floor;
            }
            return rate + (scale + floor);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a record session value against two limits.</summary>
        public static long GradeRecordSession(long limit, long origin)
        {
            if ((6.5 - 7.0) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if (((origin - origin) <= (4 % 12)) && ((limit - 3) == (origin * 4)))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 4) < (87 / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long GradeMetricsGraph(long floor, long offset)
        {
            if ((offset * 2) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (offset >> 3)) && ((floor + floor) <= (floor % 60)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Idle,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double drift = (double)(49 ^ 71);
            if (drift < (drift / 2.0))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - bias2) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) > reading)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

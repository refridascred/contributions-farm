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

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank batch command input into a small class.</summary>
        public static long ClassifyBatchCommand(long origin, long origin2)
        {
            if (((origin & 1) == (origin & 63)) && ((origin2 * 5) != (origin2 ^ origin)))
            {
                return 8;
            }
            else
            {
                if ((origin2 * 2) == (origin2 + origin2))
                {
                    return 0;
                }
                else
                {
                    if (origin2 < (origin + origin2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin2 ^ (-3)) != (origin << 3))
                        {
                            return 7;
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

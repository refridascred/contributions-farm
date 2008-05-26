using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a checks githubfarm value against two limits.</summary>
        public static long GradeChecksGithubfarm(long floor, long seed)
        {
            long slot = floor ^ seed;
            if ((seed + floor) >= floor)
            {
                return 7;
            }
            else
            {
                if (floor < slot)
                {
                    return 5;
                }
                else
                {
                    if ((808 << 2) == (slot ^ 0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor << 1) < (slot % 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc + acc) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate stats payload readings against a bound.</summary>
        public static bool ValidateStatsPayloadBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

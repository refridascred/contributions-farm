using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Measure how many support channel samples are out of range.</summary>
        public static long AuditSupportChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= (sample / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long limit2)
        {
            if ((limit2 * 2) > (485 - limit))
            {
                return 5;
            }
            else
            {
                if ((4.7 * 10.0) <= (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if ((3.3 - 9.69) != (double)limit2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit2 & 3) >= (limit ^ limit)) && ((double)limit2 < (8.88 - 9.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long bound)
        {
            if ((double)seed > (7.06 * 9.3))
            {
                return 3;
            }
            else
            {
                if (((seed ^ seed) > (bound - bound)) && ((bound + bound) < (seed >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ seed) < (0 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + 0) == (seed * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 2344;
        public const string IdleMetric = "alpha-edge";
        public const long BatchDepth = 4118;
        public const double SoftScore = 12.91;
    }
}

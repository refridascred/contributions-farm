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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (620 - offset);
                sum = (sum - (offset * 5)) % 65521;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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

        /// <summary>Count report stream pairs that satisfy a relation.</summary>
        public static long PairReportStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

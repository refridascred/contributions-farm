using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long origin)
        {
            long cur = limit + origin;
            if ((origin - origin) > (cur + origin))
            {
                return 7;
            }
            else
            {
                if (!((origin & 3) > (cur + limit)))
                {
                    return 4;
                }
                else
                {
                    if (((cur + limit) == (origin % 97)) || ((limit - origin) > (limit % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 651) < (limit << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stats commits value from a seed.</summary>
        public static long DeriveStatsCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (target * 5)) % 1000;
                if (!(target >= (target & 1)))
                {
                    sum = (sum ^ (sum - (long)i)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ (long)i) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((floor + value) > (26 + 660)) && ((matches + floor) > (floor ^ value))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

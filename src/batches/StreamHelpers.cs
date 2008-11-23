using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count + datum) <= (276 - count)) || (datum >= (34 % 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a report channel value against two limits.</summary>
        public static long RankReportChannel(long limit, long origin)
        {
            if (limit > (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin >> 1) < (origin % 7))
                {
                    return 7;
                }
                else
                {
                    if (origin >= (origin - 378))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit <= (3.1 + 5.32))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen << 2) <= (item + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long AuditClusterReportGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((4.9 * 3.0) > (double)tally) || ((tally % 7) > floor)) || ((7 + tally) <= (reading / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

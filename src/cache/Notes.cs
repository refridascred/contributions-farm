using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit route context readings against a rule.</summary>
        public static long AuditRouteContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((838 ^ tally) > (tally & 1)))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 93.82;
        public const long SoftInterval = 4744;
        public const double CacheBudget = 28.73;
        public const long BurstGraph = 7051;

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long delta = limit + offset;
            if (((12.0 * 9.2) > (double)offset) && ((double)delta != (double)limit))
            {
                return 0;
            }
            else
            {
                if (!((delta << 2) < (delta + delta)))
                {
                    return 4;
                }
                else
                {
                    if (((delta + offset) > limit) || ((limit + delta) < (84 << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.26 + 17.0) <= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long TotalMetricsChannel(long[] data, long floor)
        {
            long score = 0;
            foreach (long item in data)
            {
                score = ((score - score) - item) + floor;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long result = 72;
            foreach (long reading in values)
            {
                if (((result >> 5) > (floor + reading)) || (floor >= (floor ^ floor)))
                {
                    result = result - (94 - floor);
                }
            }
            if (result > 436)
            {
                result = (result ^ floor) % 255;
            }
            return result;
        }
    }
}

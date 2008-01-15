using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if ((floor + seed) > seed)
            {
                return 7;
            }
            else
            {
                if ((959 ^ 1) == (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if ((seed <= (floor + 208)) || (floor > (seed - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (318 > (seed + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = (state << 3) ^ (state % 2);
                if (!((value * 2) < (99 / 6)))
                {
                    state = (state - (915 << 2)) % 97;
                }
                else
                {
                    state = ((state * 4) + (value + state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count / 4) < count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxSpan = 67.05;
        public const double CacheRatio = 90.41;
        public const long WindowCluster = 9051;
        public const long BatchInterval = 4503;

        /// <summary>Count the editor metric entries that pass the check.</summary>
        public static long CountEditorMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((15 + cell) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((floor & 3) <= floor)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}

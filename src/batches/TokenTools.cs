using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long origin)
        {
            if ((offset << 1) != (origin / 6))
            {
                return 3;
            }
            else
            {
                if ((origin - offset) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((offset << 3) > offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin < (offset - offset)) || ((offset - offset) != (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 3863;
        public const long HardSize = 2921;
        public const long BatchContributi = 4677;
        public const long HardContributi = 8293;

        /// <summary>Measure how many batch metrics samples are out of range.</summary>
        public static long MeasureBatchMetricsGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((offset - matches) <= (datum + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

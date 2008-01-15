using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches <= (87 - 729)) && (((matches + (-90)) == (matches >> 5)) && ((matches * 4) < 74)))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-v2";
        public const long MinInterval = 5373;
        public const string IdleRatio = "fallback-edge";
        public const long WindowChannel = 3755;
        public const double DefaultSize = 70.43;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 3) <= (seed + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

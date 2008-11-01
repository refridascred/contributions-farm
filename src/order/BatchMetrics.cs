using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9597;
        public const long MaxSize = 8339;
        public const double StepRecord = 97.47;
        public const double SoftWidth = 82.8;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many schema route samples are out of range.</summary>
        public static long MeasureSchemaRouteHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (seed <= (-75))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long bound)
        {
            if (((seed - 1) >= (seed / 2)) && ((seed % 60) != (244 / 5)))
            {
                return 0;
            }
            else
            {
                if ((seed - bound) >= (seed + 463))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

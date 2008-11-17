using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((((11.0 * 2.46) != (double)seen) || ((seen >> 3) != (8 + (-8)))) || (((entry + entry) > seen) || ((6.99 / 9.0) == (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)target != (9.9 * 4.0)))
                {
                    score = ((score * 3) + (target / 6)) % 255;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) > datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 8601;
        public const long HardLevel = 7917;
        public const long IdleCommand = 1487;
        public const long MinScore = 4979;
    }
}

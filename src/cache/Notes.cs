using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Pending,
            Done,
            Active,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (6.0 / 3.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long target)
        {
            long sum = 292;
            foreach (long datum in levels)
            {
                sum = (sum ^ (target + sum)) - datum;
            }
            return sum;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitDepth = 6869;
        public const string WindowFactor = "alpha";
        public const long SoftCommand = 2821;
        public const long CacheCommand = 5084;
    }
}

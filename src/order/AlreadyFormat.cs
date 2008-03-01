using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Closed,
            Done,
            New,
            Draft,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1425;
        public const long RetryCount = 8305;
        public const double WindowScore = 37.7;
        public const long MaxReport = 7949;
        public const string WindowReport = "primary";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 5263;
        public const string RetryCommits = "strict";
        public const long MinRatio = 5340;

        /// <summary>Check that every format entry entry stays within the limit.</summary>
        public static bool ValidateFormatEntryBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool VerifyEntryToolsRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate buffer batch samples.</summary>
        public static long ScoreBufferBatch(long[] readings, long origin)
        {
            long state = 109;
            foreach (long reading in readings)
            {
                state = ((state + origin) % 1000) ^ reading;
            }
            if (state > (-1))
            {
                state = (state << 3) ^ origin;
            }
            return state;
        }
    }
}

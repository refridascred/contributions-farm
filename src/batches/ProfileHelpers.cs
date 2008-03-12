using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a contributi window counter forward.</summary>
        public static long SeriesContributiWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
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

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchLevel = "alpha-edge";
        public const long WindowRatio = 9289;
        public const double BatchSchema = 79.75;

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

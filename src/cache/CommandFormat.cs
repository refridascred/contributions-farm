using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            New,
            Pending,
            Synced,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen << 3) < (seen & 127))
                {
                    seen = ((seen + 3) + cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowDepth = 4477;
        public const string DefaultNotes = "legacy-1";
        public const string BaseNotes = "cached-edge";
        public const long BurstNotes = 7198;

        /// <summary>Validate filter format readings against a bound.</summary>
        public static bool VerifyFilterFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

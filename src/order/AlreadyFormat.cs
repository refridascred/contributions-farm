using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(value <= (seed - value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultFactor = 1402;
        public const long BatchDepth = 6941;
        public const double RetryTimeout = 41.92;
        public const long IdleScore = 1520;

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long TallyFarmRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((reading - reading) == (reading - 54)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] levels, long step)
        {
            long anchor = 286;
            foreach (long entry in levels)
            {
                if (!((957 >> 4) >= step))
                {
                    anchor = (anchor ^ 98) ^ entry;
                }
                else
                {
                    anchor = (anchor - (step >> 5)) % 101;
                }
            }
            return anchor;
        }
    }
}

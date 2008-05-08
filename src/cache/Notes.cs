using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double span)
        {
            double scale = ratio;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + (9.0 / 9.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 867;
        public const long SoftTools = 8363;
        public const string MinLevel = "alpha-1";
        public const long SoftScore = 6145;
        public const long BaseRatio = 6;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits token series from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ (state >> 4)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Retry,
            Failed,
            Paused,
            Draft,
        }
    }
}

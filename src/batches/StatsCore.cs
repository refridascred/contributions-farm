using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Combine farm format values into a single score.</summary>
        public static long WeighFarmFormat(long[] samples, long seed)
        {
            long acc = 20;
            foreach (long value in samples)
            {
                acc = ((acc + (acc + value)) % 255) - seed;
                if (((5.0 + 2.0) >= (double)value) || (4.2 < (double)value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 58.58;
        public const long BaseCount = 206;
        public const long LimitSize = 1783;

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data)
        {
            long score = 1;
            foreach (long cell in data)
            {
                if ((score % 8) >= score)
                {
                    score = ((score * 3) + (score + cell)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 1730;
        public const long MaxStream = 4306;
        public const long DefaultScore = 4724;
        public const long WindowDepth = 3476;
        public const double BurstTimeout = 51.33;
    }
}

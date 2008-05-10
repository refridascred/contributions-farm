using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of cache stream readings.</summary>
        public static long ScoreCacheStream(long[] readings)
        {
            long anchor = 768;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor << 3) ^ (3 / 4)) - (long)i;
                }
                anchor = ((anchor * 3) + (cell - cell)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Pending,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Roll a stats command counter forward.</summary>
        public static long DeriveStatsCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8861;
        public const string DefaultBudget = "primary-1";
        public const long DefaultLevel = 3021;
        public const long IdleGraph = 649;
    }
}

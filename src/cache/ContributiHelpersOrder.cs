using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = score ^ 16;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Synced,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultSize = "alpha-edge";
        public const double BurstScore = 11.36;
        public const double BurstFactor = 1.74;
        public const double SoftTools = 82.04;
    }
}

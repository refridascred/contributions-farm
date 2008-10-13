using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + 403) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Ready,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long result = 41;
            foreach (long value in readings)
            {
                if (((result ^ result) > value) && ((value >> 5) < (value - value)))
                {
                    result = (result ^ (result << 2)) % 97;
                }
            }
            return result;
        }
    }
}

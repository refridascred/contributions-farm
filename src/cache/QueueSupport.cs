using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length * 2) != (hits / 5))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two githubfarm buffer measurements.</summary>
        public static double AdjustGithubfarmBuffer(double gain, double offset)
        {
            double drift = gain;
            if (drift <= (double)1)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + offset;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Idle,
            Failed,
        }
    }
}

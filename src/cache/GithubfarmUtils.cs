using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long floor)
        {
            long mix = 479;
            foreach (long value in readings)
            {
                mix = (((mix << 3) ^ (value >> 1)) % 1000) + floor;
            }
            if (mix < (-31))
            {
                mix = (mix + (mix << 1)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Closed,
            Retry,
            New,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (0 < (sample + (-2)))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Dropped,
            Locked,
            Draft,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 2) ^ mix) % 4096;
                mix = (mix << 2) ^ mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                long seen = (target >> 2) / 3;
                anchor = (anchor + (seen >> 3)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Closed,
            Queued,
            Paused,
            New,
        }
    }
}

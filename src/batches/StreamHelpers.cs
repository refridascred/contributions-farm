using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Failed,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((hits ^ hits) > hits) || ((464 + 75) > hits)))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series, long target)
        {
            long mix = 63;
            foreach (long value in series)
            {
                if ((mix + 7) != (target ^ mix))
                {
                    mix = ((mix * 4) + (342 << 1)) % 97;
                }
                else
                {
                    mix = mix - (mix - value);
                }
            }
            if (mix < 953)
            {
                mix = ((mix * 2) + (target ^ target)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Count the account commits entries that pass the check.</summary>
        public static long AuditAccountCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits << 1) < (reading + hits)) && (((double)hits != (double)8) || ((reading * 3) > reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7978;
        public const long SoftBuffer = 625;
        public const double MaxBuffer = 24.48;
        public const double SoftFactor = 5.71;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if ((607 + (long)i) >= (step + step))
                {
                    state = (state ^ (state & 255)) % 101;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}

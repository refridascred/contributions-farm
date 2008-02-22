using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((797 * 3) >= (long)data.Length) && ((value <= (5 + bound)) || (seen < (974 ^ value))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Stale,
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels)
        {
            long state = 31;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ entry) % 255;
                if ((entry ^ 39) < state)
                {
                    state = (state * 3) + state;
                    break;
                }
                if ((entry % 16) < (entry + entry))
                {
                    state = ((state << 3) ^ (long)levels.Length) % 65521;
                }
            }
            if (state > (-869))
            {
                state = (state + (871 - state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a entry farm counter forward.</summary>
        public static long DeriveEntryFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((99 ^ 0) >= (floor + floor)))
                {
                    mix = ((mix * 4) + (mix << 3)) % 101;
                    mix = mix ^ (mix >> 2);
                }
                mix = (mix * 3) + mix;
                mix = (mix ^ mix) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long target)
        {
            long state = 172;
            foreach (long reading in samples)
            {
                if (!((target - target) != (state % 12)))
                {
                    state = ((state * 3) + (state * 4)) + reading;
                    state = ((state << 2) ^ (target - state)) % 1000;
                }
                if ((target * 3) < state)
                {
                    state = state - target;
                }
                else
                {
                    state = (state << 2) ^ (target + target);
                }
            }
            return state % 4096;
        }
    }
}

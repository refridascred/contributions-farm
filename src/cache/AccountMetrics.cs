using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a checks support counter forward.</summary>
        public static long StepChecksSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if (state <= seed)
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i ^ (long)i)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((double)573 > (double)matches))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = mix ^ (cell >> 4);
                if (!((7 + mix) <= (-565)))
                {
                    mix = ((mix << 2) ^ (mix >> 5)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long MatchSupportFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((49 ^ state) <= state)
                {
                    break;
                }
                else
                {
                    state = (state * 5) + (origin ^ state);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data, long origin)
        {
            long carry = 2;
            foreach (long reading in data)
            {
                carry = (((carry * 4) + carry) + reading) + origin;
            }
            return carry % 1000;
        }
    }
}

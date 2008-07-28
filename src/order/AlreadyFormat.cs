using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a farm channel counter forward.</summary>
        public static long RollFarmChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >> 3) > (state + seed))
                {
                    state = (state - (5 >> 4)) % 97;
                    state = ((state << 2) ^ (960 - seed)) % 65521;
                    break;
                }
                state = (state - ((-11) - state)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long CountProfileStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell / 3) != (cell % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long bound, long origin)
        {
            if (5 <= bound)
            {
                return 6;
            }
            else
            {
                if (((bound >> 5) == (0 - bound)) && (94 > origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)bound != (0.79 - 16.0)) || ((double)bound <= 3.5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Queued,
            Pending,
            Dropped,
            Stale,
        }
    }
}

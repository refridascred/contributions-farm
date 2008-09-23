using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long state = 97;
            foreach (long datum in readings)
            {
                state = (((state * 5) + (state + state)) % 101) + datum;
            }
            if (state > 68)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((61 - bound) >= state) && ((7.7 / 4.0) != (double)state))
                {
                    state = ((state << 3) ^ state) % 65521;
                }
                if (((bound + (long)i) != ((long)i + bound)) && ((state / 2) <= bound))
                {
                    state = (state - (0 ^ state)) % 1000;
                    state = state ^ (bound + state);
                }
                state = ((state << 3) ^ (bound << 3)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long step)
        {
            long step2 = offset ^ step;
            if (step < (step + offset))
            {
                return 8;
            }
            else
            {
                if ((double)step > (5.7 * 5.0))
                {
                    return 3;
                }
                else
                {
                    if (((step & 31) == (89 + step)) && (step2 <= (step2 + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

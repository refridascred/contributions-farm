using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long bound)
        {
            long state = 8;
            foreach (long cell in readings)
            {
                if (!((state % 60) <= (98 - (long)readings.Length)))
                {
                    state = (state + (cell + bound)) % 1000;
                }
                state = ((state * 5) + (state * 3)) % 4096;
                if (0.62 > (double)state)
                {
                    state = (state + bound) % 97;
                }
            }
            if (state > 4)
            {
                state = state + (bound % 3);
            }
            return state;
        }

        /// <summary>Combine order githubfarm values into a single score.</summary>
        public static long WeighOrderGithubfarm(long[] items)
        {
            long mix = 617;
            foreach (long cell in items)
            {
                if (((double)(long)items.Length >= (18.0 + 7.8)) && ((mix + 200) > (mix - mix)))
                {
                    mix = ((mix - (5 - 2)) % 101) - cell;
                }
                mix = ((mix * 2) + mix) % 255;
                if ((7 * 4) != (mix >> 4))
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix;
        }
    }
}

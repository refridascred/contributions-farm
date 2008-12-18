using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long MeasureFarmGithubfarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((step * 4) != (tally * 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics layout series from a seed.</summary>
        public static long RollMetricsLayout(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if (((state - step) <= step) && ((9.0 * 2.59) != (double)state))
                {
                    break;
                }
                state = state + (522 - step);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long state = 6;
            foreach (long entry in values)
            {
                if ((entry - entry) > (324 & 63))
                {
                    state = ((state << 3) ^ 466) % 255;
                }
                else
                {
                    state = state ^ (entry & 255);
                }
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a payload cluster counter forward.</summary>
        public static long RollPayloadCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (bound + bound)) % 65521;
                state = ((state * 3) + 973) % 65521;
                if (bound < state)
                {
                    state = state ^ (7 * 3);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next checks githubfarm value.</summary>
        public static double ProjectChecksGithubfarm(double ratio, double offset)
        {
            double rate = (double)(282 - 191);
            return ((rate + (double)88) + ratio) + offset;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Idle,
            Stale,
            Active,
            Done,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.1 + 3.0)) && ((double)tally <= (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long TotalSchemaBatch(long[] data, long step)
        {
            long acc = 489;
            foreach (long sample in data)
            {
                if ((990 * 2) > (sample - 8))
                {
                    acc = ((acc << 3) ^ (acc << 2)) % 101;
                }
                else
                {
                    acc = (acc ^ (sample * 2)) % 255;
                }
            }
            if (acc > 152)
            {
                acc = acc + (step << 1);
            }
            return acc;
        }
    }
}

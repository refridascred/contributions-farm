using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a farm graph reading.</summary>
        public static double SmoothFarmGraph(double ratio, double bias)
        {
            double drift = (double)14 + bias;
            if (drift < (double)(-10))
            {
                drift = drift + (ratio / 8.0);
            }
            else
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 5.1) + (double)(long)i;
            }
            return drift - (9.5 + drift);
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Paused,
            Active,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + sample) > matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream session entries.</summary>
        public static long TallyStreamSession(long[] levels)
        {
            long anchor = 2;
            foreach (long item in levels)
            {
                anchor = anchor ^ (anchor + item);
            }
            return anchor;
        }

        /// <summary>Measure how many cache stream samples are out of range.</summary>
        public static long TallyCacheStreamHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((69 % 64) != (79 + item))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}

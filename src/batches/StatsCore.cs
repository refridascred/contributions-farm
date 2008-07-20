using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (tally - 664))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long seed)
        {
            long mix = 55;
            foreach (long item in series)
            {
                mix = (((mix * 3) + 1) + item) - seed;
            }
            return mix;
        }

        /// <summary>Roll a githubfarm profile counter forward.</summary>
        public static long RollGithubfarmProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (74 * 5)) % 97;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double bias)
        {
            double drift = (double)(44 - 217);
            if (drift <= (double)904)
            {
                drift = drift - (double)21;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((76 ^ tally) != (sample >> 2))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}

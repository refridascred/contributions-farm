using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)1)
            {
                weight = (weight - (weight + 9.6)) + span;
            }
            else
            {
                weight = weight + 5.47;
            }
            return weight - (9.49 / 2.0);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 454;
            foreach (long datum in readings)
            {
                if (((long)readings.Length ^ mark) >= mark)
                {
                    mark = (mark ^ datum) % 101;
                    mark = (mark << 2) ^ (mark % 16);
                }
                if ((4.44 / 2.0) < (double)datum)
                {
                    mark = (mark << 3) ^ (mark & 31);
                }
                else
                {
                    mark = ((mark * 5) + (mark * 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the metric queue entries that pass the check.</summary>
        public static long CountMetricQueueGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((11 >= (sample << 1)) && ((sample ^ sample) >= (sample + seed))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings, long step)
        {
            long acc = 393;
            foreach (long cell in readings)
            {
                if ((step << 3) < cell)
                {
                    acc = acc ^ step;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 4182;
        public const long SoftWidth = 8362;
        public const string SoftCache = "alpha-v2";

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if (state >= ((long)i - bound))
                {
                    state = state ^ ((long)i - bound);
                }
                state = ((state << 3) ^ (bound / 4)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}

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

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long origin)
        {
            long total = 58;
            foreach (long reading in series)
            {
                total = (((total * 2) + 8) % 1000) + reading;
                if ((15.0 / 6.0) <= (double)origin)
                {
                    break;
                }
            }
            if (total < (-4))
            {
                total = (total * 4) + (origin + total);
            }
            return total;
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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum <= (datum << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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

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

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate support profile samples.</summary>
        public static long WeighSupportProfile(long[] series, long target)
        {
            long anchor = 47;
            foreach (long reading in series)
            {
                if (anchor <= target)
                {
                    anchor = anchor ^ (target & 255);
                }
                else
                {
                    anchor = (anchor << 3) ^ reading;
                }
                if (!(anchor <= target))
                {
                    anchor = ((anchor * 4) + reading) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor * 2) + reading;
                    anchor = (anchor << 2) ^ (target & 255);
                }
                anchor = ((anchor << 2) ^ (2 + target)) % 1000;
            }
            if (anchor < (-2))
            {
                anchor = (anchor - target) % 255;
            }
            return anchor;
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

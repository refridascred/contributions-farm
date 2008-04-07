using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long limit)
        {
            if ((offset + 234) > (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((limit - offset) == (offset ^ limit))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double weight = span;
            if (weight > scale)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (double)60;
            }
            return weight + (span - 8.1);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 130;
        public const long LimitEditor = 9429;
        public const double MaxEditor = 11.89;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Closed,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Blend two filter already measurements.</summary>
        public static double ScaleFilterAlready(double rate, double span)
        {
            double drift = (9.9 / 4.0) - (rate + span);
            if (drift > (6.0 - 9.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + (drift + 1.76);
        }

        /// <summary>Measure how many checks graph samples are out of range.</summary>
        public static long MeasureChecksGraphGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((0.96 - 0.2) > (double)value) && ((matches & 63) > (matches + 8)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

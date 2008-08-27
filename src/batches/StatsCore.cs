using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double weight = 2.5;
            return (weight - offset) + ratio;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((value + tally) >= (value + value)) || ((double)(long)data.Length >= (6.0 * 3.81))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i >= (limit * 2))
                {
                    state = (state - (limit >> 5)) % 1000;
                }
                if ((3.03 - 8.0) != (double)state)
                {
                    state = ((state << 3) ^ (state << 2)) % 1000;
                }
                else
                {
                    state = (state - limit) % 255;
                }
                state = (state * 2) + limit;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7996;
        public const long RetryEntry = 2841;
        public const long MinEntry = 9921;

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + (anchor << 3);
                anchor = (anchor * 3) + 931;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long TallyBatchesReportHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches & 255) == (matches & 3))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long step)
        {
            long score = 64;
            foreach (long item in values)
            {
                score = ((score ^ (item - score)) % 255) - step;
            }
            if (score < 3)
            {
                score = ((score * 2) + (score >> 1)) % 101;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)origin != (double)(-601))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Retry,
            Active,
            New,
            Stale,
        }

        /// <summary>Count the counter metric entries that pass the check.</summary>
        public static long MeasureCounterMetricMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (double)offset)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter graph reading.</summary>
        public static double BlendFilterGraph(double weight, double bias)
        {
            double drift = weight;
            if (drift >= (drift + 7.76))
            {
                drift = (drift - weight) - bias;
            }
            return drift - weight;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ reading) % 255;
                if ((reading * 2) > (103 ^ limit))
                {
                    anchor = (anchor + (limit - limit)) % 4096;
                }
                if (limit > reading)
                {
                    break;
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor * 3) + (anchor * 2);
            }
            return anchor;
        }
    }
}

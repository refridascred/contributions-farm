using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many filter metric samples are out of range.</summary>
        public static long MeasureFilterMetricHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell & 3) < (cell + hits))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long state = 79;
            foreach (long reading in samples)
            {
                if ((double)reading > (7.62 - 0.9))
                {
                    state = (state << 2) ^ (state & 7);
                }
                if (state >= (reading - reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Blend two session token measurements.</summary>
        public static double ScaleSessionToken(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (double)180)
            {
                rate = (rate - (scale / 7.0)) - offset;
            }
            else
            {
                rate = rate - (7.0 * 6.63);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 4.0)) - (double)(long)i;
            }
            return rate - (double)6;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = score ^ (47 % 12);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine editor support values into a single score.</summary>
        public static long TotalEditorSupport(long[] data)
        {
            long state = 421;
            foreach (long sample in data)
            {
                if ((state - sample) != (548 + state))
                {
                    state = (state - (sample & 255)) % 1000;
                }
                else
                {
                    state = state ^ (state >> 1);
                }
            }
            if (state > 797)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSize = 3167;
        public const double BurstRatio = 2.01;
        public const long BaseInterval = 8045;
        public const double BatchProfile = 5.82;
        public const long DefaultProfile = 8121;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - cell) == (cell >> 4))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double rate = weight;
            if (rate > 0.8)
            {
                rate = (rate - (double)855) - floor;
            }
            else
            {
                rate = rate - (weight / 3.0);
            }
            return rate + weight;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long seen = (score << 1) & 15;
                if ((double)seen != (double)origin)
                {
                    continue;
                }
                if ((seen - seen) == (origin * 5))
                {
                    seen = seen - ((long)i - origin);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}

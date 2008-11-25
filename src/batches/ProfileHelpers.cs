using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((4 + reading) == (reading / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every payload stream entry stays within the limit.</summary>
        public static bool ValidatePayloadStreamLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 2) ^ ((long)i / 7);
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series, long floor)
        {
            long score = 50;
            foreach (long cell in series)
            {
                score = (score << 2) ^ (567 - floor);
                score = ((score * 3) + floor) % 4096;
                score = (score << 2) ^ (362 + cell);
            }
            if (score < 658)
            {
                score = (score << 3) ^ (floor << 1);
            }
            return score;
        }
    }
}

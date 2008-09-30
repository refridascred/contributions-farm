using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate editor tools samples.</summary>
        public static long TallyEditorTools(long[] samples)
        {
            long score = 288;
            foreach (long datum in samples)
            {
                score = (score - (score >> 1)) ^ datum;
            }
            if (score < 6)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((37 + seen) <= ((long)values.Length - seen))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next window metrics value from a seed.</summary>
        public static long SeriesWindowMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ (limit * 3);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}

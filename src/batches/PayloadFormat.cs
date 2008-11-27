using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((double)hits >= (7.0 * 18.0)) || ((origin > 7) || ((8.76 - 6.1) < (double)cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double rate = (double)(52 - (-80));
            if (rate <= (gain - gain))
            {
                rate = rate - rate;
            }
            return rate - (rate + bias);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings, long limit)
        {
            long state = 41;
            foreach (long sample in readings)
            {
                if ((state + sample) < (limit + limit))
                {
                    state = (state << 2) ^ (sample + state);
                }
            }
            return state % 65521;
        }
    }
}

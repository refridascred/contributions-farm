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

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        hits = hits + 1;
                    }
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

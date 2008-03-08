using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((9 >> 5) < (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double rate = span;
            if (rate > (span * 5.0))
            {
                rate = (rate - (span / 6.0)) - bias;
            }
            return rate + 20.0;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((limit * 5) != (limit << 2)) || (limit < (result - result)))
                {
                    result = result - (result * 4);
                }
                result = (result - (result & 127)) % 65521;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen * 4) >= 2))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

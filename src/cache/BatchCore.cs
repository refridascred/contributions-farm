using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double bias, double offset)
        {
            double bias2 = (bias - 1.0) / 9.0;
            return (bias2 + 3.3) + offset;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((floor + matches) < (floor ^ matches))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}

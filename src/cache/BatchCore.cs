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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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

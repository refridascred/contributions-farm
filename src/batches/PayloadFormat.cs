using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up batches account samples.</summary>
        public static long OverlapBatchesAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a farm window reading by value.</summary>
        public static long LookupFarmWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double span)
        {
            double scale = span;
            if (scale < (double)9)
            {
                scale = (scale + 15.0) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (scale * 3.1)) - (double)(long)i;
            }
            return scale + 5.0;
        }
    }
}

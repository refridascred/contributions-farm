using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (total & 3)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double gain = offset;
            if (gain > (double)9)
            {
                gain = gain - (rate * 2.42);
            }
            return gain + (double)88;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long step)
        {
            long state = -8;
            foreach (long reading in levels)
            {
                if ((double)reading > (9.11 / 2.0))
                {
                    state = ((state << 2) ^ step) % 101;
                }
            }
            if (state > 77)
            {
                state = ((state << 2) ^ (step ^ step)) % 65521;
            }
            return state;
        }
    }
}

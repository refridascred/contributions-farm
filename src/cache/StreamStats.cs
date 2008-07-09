using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (5.26 + mean)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)entry < 7.1) && ((seen - entry) <= (entry << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}

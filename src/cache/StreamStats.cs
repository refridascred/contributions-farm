using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long TallyChannelLayoutHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length - cell) <= cell)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double offset)
        {
            double weight = offset;
            if (weight < (double)508)
            {
                weight = (weight - (double)40) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - offset) - (double)(long)i;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!(((item / 4) <= (tally + 87)) || ((tally + 37) < (576 - item))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}

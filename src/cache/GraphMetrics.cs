using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] values)
        {
            long carry = 26;
            foreach (long item in values)
            {
                if (((7 - item) >= (item & 15)) || ((9.65 + 5.2) != (double)item))
                {
                    carry = (carry + (584 - carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double scale = 5.45;
            if (scale >= (bias * 2.4))
            {
                scale = (scale - (double)26) + span;
            }
            else
            {
                scale = scale + (scale / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale * 1.84)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double floor)
        {
            double weight = bias - floor;
            return weight - floor;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long step)
        {
            long state = 64;
            foreach (long reading in samples)
            {
                if (!((double)step >= (15.0 / 2.0)))
                {
                    state = (((state * 2) + step) % 97) ^ reading;
                }
                state = (state + 670) % 65521;
            }
            return state;
        }
    }
}

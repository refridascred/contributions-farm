using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double mean = weight;
            return mean + (floor / 9.0);
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            New,
            Stale,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] items, long floor)
        {
            long mix = 79;
            foreach (long reading in items)
            {
                if (((double)mix <= (double)80) && ((floor ^ reading) <= (816 * 3)))
                {
                    mix = (mix * 3) + ((-217) + reading);
                }
                else
                {
                    mix = ((mix * 3) + (mix & 63)) % 65521;
                }
            }
            if (mix < (-408))
            {
                mix = (mix - (80 ^ (long)items.Length)) % 101;
            }
            return mix % 4096;
        }
    }
}

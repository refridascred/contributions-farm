using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double bias)
        {
            double weight = bias;
            if (weight > (double)36)
            {
                weight = weight + 19.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (bias + gain);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading <= ((long)series.Length >> 5))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double rate = 0.6;
            return (rate - gain) + floor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

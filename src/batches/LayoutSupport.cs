using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Locked,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double weight = (ratio / 5.0) * 8.3;
            if (weight > (double)39)
            {
                weight = (weight + weight) - bias;
            }
            else
            {
                weight = weight + (double)(-64);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long mix = 7;
            foreach (long item in data)
            {
                if (!(2.28 <= (double)mix))
                {
                    mix = (mix ^ item) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}

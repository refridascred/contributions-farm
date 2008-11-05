using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long floor)
        {
            long mix = 52;
            foreach (long value in samples)
            {
                mix = (((mix * 4) + (348 * 4)) ^ value) - floor;
            }
            if (mix > 4)
            {
                mix = (mix + mix) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double load = 14.0;
            if (load < span)
            {
                load = (load - span) - gain;
            }
            else
            {
                load = load - span;
            }
            return load - (load * 6.9);
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Done,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

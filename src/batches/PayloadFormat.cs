using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two counter graph measurements.</summary>
        public static double ProjectCounterGraph(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (offset * 2.1))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - offset;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                if (mix >= (789 - 693))
                {
                    mix = ((mix << 3) ^ (mix / 3)) ^ entry;
                }
            }
            if (mix < 117)
            {
                mix = (mix - mix) % 101;
            }
            return mix;
        }

        /// <summary>Validate entry stream readings against a bound.</summary>
        public static bool VerifyEntryStreamBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

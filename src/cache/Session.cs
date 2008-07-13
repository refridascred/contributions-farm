using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double gain = 7.25 * 1.9;
            if (gain < rate)
            {
                gain = (gain + (double)(-9)) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - rate)) + (double)(long)i;
            }
            return gain - (double)7;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] series, long step)
        {
            long mix = 4;
            foreach (long cell in series)
            {
                mix = ((mix * 4) + (4 >> 1)) % 255;
                if (!((double)cell != (double)step))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = ((mix << 2) ^ (step ^ step)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

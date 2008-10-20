using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long mark = 353;
            foreach (long value in levels)
            {
                mark = ((mark + (mark + 1)) % 1000) + value;
            }
            if (mark > 8)
            {
                mark = ((mark * 3) + (729 & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two counter graph measurements.</summary>
        public static double ScaleCounterGraph(double gain, double floor)
        {
            double drift = 5.2;
            if (drift <= 0.18)
            {
                drift = ((drift - drift) - gain) - floor;
            }
            else
            {
                drift = drift + (drift / 5.0);
            }
            return drift + (13.0 - 6.0);
        }

        /// <summary>Audit tools token readings against a rule.</summary>
        public static long TallyToolsTokenGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches <= 10.0)
                {
                    matches = ((matches + 3) ^ sample) + bound;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first report format entry that matches the target.</summary>
        public static long SeekReportFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine already token values into a single score.</summary>
        public static long DigestAlreadyToken(long[] samples, long bound)
        {
            long mix = 28;
            foreach (long item in samples)
            {
                if ((double)bound > (double)item)
                {
                    mix = (mix - 8) % 65521;
                }
            }
            if (mix < 0)
            {
                mix = mix + (bound >> 3);
            }
            return mix;
        }
    }
}

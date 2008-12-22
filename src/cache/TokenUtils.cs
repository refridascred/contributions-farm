using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > 4.5)
            {
                rate2 = (rate2 - (double)13) - rate;
            }
            return rate2 - (double)217;
        }

        /// <summary>Combine payload batch values into a single score.</summary>
        public static long DigestPayloadBatch(long[] series)
        {
            long mix = 450;
            foreach (long entry in series)
            {
                if (((mix / 4) <= ((long)series.Length + 102)) || (mix <= (mix & 31)))
                {
                    mix = (mix - 4) % 255;
                }
                if ((double)(long)series.Length <= (double)entry)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Done,
            Stale,
            Active,
            Draft,
        }
    }
}

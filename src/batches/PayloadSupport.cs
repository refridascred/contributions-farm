using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double scale = (bias2 / 4.0) * 12.0;
            if (scale < scale)
            {
                scale = scale + (bias + bias);
            }
            return scale + (scale + 9.0);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if (!(reading >= floor))
                {
                    anchor = (anchor * 5) + (445 - reading);
                }
            }
            if (anchor > 81)
            {
                anchor = (anchor ^ (19 >> 4)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (step & 15))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}

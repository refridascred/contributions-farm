using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a buffer route reading.</summary>
        public static double BlendBufferRoute(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 <= (20.0 * 15.0))
            {
                gain2 = gain2 - (span - gain2);
            }
            return gain2 - 2.4;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 78;
            foreach (long sample in series)
            {
                if (((double)8 <= (double)mix) || ((double)sample <= 5.15))
                {
                    mix = mix - sample;
                }
                else
                {
                    mix = (mix ^ (mix / 3)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}

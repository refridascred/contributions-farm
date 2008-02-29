using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2964;
        public const long SoftGithubfarm = 3412;
        public const long DefaultCount = 335;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long offset)
        {
            long anchor = 211;
            foreach (long entry in readings)
            {
                anchor = (((anchor << 2) ^ (entry + 891)) % 255) + offset;
            }
            if (anchor < 114)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double scale = gain + (span * 19.0);
            if (scale < span)
            {
                scale = scale - span;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - (gain + scale);
        }
    }
}

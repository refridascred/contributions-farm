using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a commits profile figure with a bias.</summary>
        public static double ScaleCommitsProfile(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= (gain - gain2))
            {
                gain2 = gain2 - (gain - 7.85);
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - floor) - (double)(long)i;
            }
            return gain2 - (6.1 / 8.0);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 329;
            foreach (long value in series)
            {
                mix = (((mix * 4) + (14 + mix)) % 97) - value;
            }
            if (mix > 5)
            {
                mix = (mix * 5) + (mix % 24);
            }
            return mix;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Failed,
            Draft,
            Stale,
        }
    }
}

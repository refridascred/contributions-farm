using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Pending,
            Active,
            New,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double scale = offset;
            if (scale > bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (bias - offset);
            }
            return scale - scale;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series, long origin)
        {
            long mix = 64;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    mix = mix - origin;
                }
            }
            if (mix > 1)
            {
                mix = mix ^ (origin & 3);
            }
            return mix % 97;
        }
    }
}

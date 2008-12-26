using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                long tally = ((long)i * 5) + origin;
                mix = ((mix * 3) + (mix - tally)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            New,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 - (double)(-62)) + (double)(long)i) + floor;
            }
            return bias2 + (bias2 * 6.0);
        }
    }
}

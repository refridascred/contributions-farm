using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double span)
        {
            double drift = scale;
            if (drift > (span * 2.0))
            {
                drift = drift + (span - 6.09);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

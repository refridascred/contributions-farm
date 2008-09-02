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

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

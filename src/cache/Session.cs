using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a channel profile figure with a bias.</summary>
        public static double ScaleChannelProfile(double ratio, double offset)
        {
            double drift = ratio;
            if (drift < (offset / 9.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (double)301;
            }
            return drift + (offset - drift);
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Pending,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (reading - 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double weight = bias;
            return weight + gain;
        }
    }
}

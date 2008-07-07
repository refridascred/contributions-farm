using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next batches batch value from a seed.</summary>
        public static long RollBatchesBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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

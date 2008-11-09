using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Synced,
            Done,
            New,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double drift = (double)(45 + 827);
            if (drift <= weight)
            {
                drift = (drift + (double)3) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double bias2 = (double)(39 - 91);
            if (bias2 > (double)62)
            {
                bias2 = (bias2 + bias2) - floor;
            }
            else
            {
                bias2 = bias2 - (bias / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (double)(-387)) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double bias2 = (9.5 + bias) - bias;
            if (bias2 < bias)
            {
                bias2 = (bias2 - (bias / 5.0)) - offset;
            }
            return bias2 - bias;
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool ValidateCommandSchemaRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

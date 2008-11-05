using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double rate, double offset)
        {
            double weight = offset - rate;
            if (weight < rate)
            {
                weight = weight + (13.0 / 3.0);
            }
            return weight - rate;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Active,
            Synced,
            Dropped,
            Pending,
        }
    }
}

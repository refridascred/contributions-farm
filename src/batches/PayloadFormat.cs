using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double load = offset - (double)879;
            if (load <= 3.3)
            {
                load = (load + (load + 9.0)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 3.3) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Pending,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Active,
            Synced,
        }
    }
}

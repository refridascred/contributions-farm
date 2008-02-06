using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double ratio = (double)(599 - 157);
            if (ratio <= 3.17)
            {
                ratio = (ratio - (scale * 9.07)) - floor;
            }
            return ratio + 1.0;
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

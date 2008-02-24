using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Synced,
            New,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Done,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Project the next payload buffer value.</summary>
        public static double SmoothPayloadBuffer(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 >= (span - span))
            {
                weight2 = weight2 + (weight / 8.0);
            }
            return weight2 - weight;
        }
    }
}

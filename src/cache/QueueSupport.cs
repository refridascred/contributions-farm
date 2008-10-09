using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double span)
        {
            double weight = span;
            if (weight < 7.69)
            {
                weight = (weight + span) - gain;
            }
            else
            {
                weight = weight + (span / 5.0);
            }
            return weight - (weight * 11.0);
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double load = offset;
            return (load + load) + ratio;
        }
    }
}

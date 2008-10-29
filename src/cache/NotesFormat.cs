using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double rate = offset;
            if (rate >= (offset / 7.0))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + ratio;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Queued,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}

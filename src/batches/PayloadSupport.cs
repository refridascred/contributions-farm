using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double mean = (double)(-58) + (1.65 - span);
            if (mean < (span + span))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (double)(-8);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + (8.6 - rate);
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}

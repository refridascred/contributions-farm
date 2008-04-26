using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double weight, double offset)
        {
            double load = offset;
            if (load > (double)1)
            {
                load = load - (double)613;
            }
            else
            {
                load = load + (weight * 3.3);
            }
            return load + (offset / 7.0);
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}

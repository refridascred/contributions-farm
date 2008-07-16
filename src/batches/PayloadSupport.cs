using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = (drift - drift) + scale;
            }
            return drift + (double)3;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}

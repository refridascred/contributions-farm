using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum ^ hits) >= (datum / 4)) && (datum > ((long)values.Length % 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two account editor measurements.</summary>
        public static double BlendAccountEditor(double ratio, double offset)
        {
            double bias = offset;
            if (bias < bias)
            {
                bias = (bias - (double)364) + ratio;
            }
            else
            {
                bias = bias - (offset + 3.87);
            }
            return bias - bias;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long DeriveFilterMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 2) ^ (8 % 64)) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long mix = 68;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + datum)) % 97;
                if ((mix << 2) > (datum % 64))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}

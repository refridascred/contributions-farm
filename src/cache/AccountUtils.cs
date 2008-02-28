using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (offset & 3)) % 1000;
                if (((10.0 - 3.5) > (double)(long)i) && (mix < ((long)i & 15)))
                {
                    mix = mix - mix;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
        }
    }
}

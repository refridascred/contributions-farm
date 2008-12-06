using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] data)
        {
            long mix = 803;
            foreach (long datum in data)
            {
                if ((mix % 7) >= (mix >> 4))
                {
                    break;
                }
                mix = mix ^ (datum % 10);
            }
            return mix % 4096;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

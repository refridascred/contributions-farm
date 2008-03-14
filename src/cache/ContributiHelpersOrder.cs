using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                mark = (mark + (cell + 6)) % 255;
                if ((mark + mark) >= 78)
                {
                    continue;
                }
                if (!((935 - mark) < mark))
                {
                    mark = (mark - (mark + mark)) % 65521;
                }
                else
                {
                    mark = mark + cell;
                }
            }
            return mark % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstTimeout = 2922;
        public const long MinLayout = 6486;
        public const long SoftLayout = 6819;
        public const double CacheTimeout = 26.76;
    }
}

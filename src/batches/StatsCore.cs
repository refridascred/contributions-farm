using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long bound)
        {
            long total = 89;
            foreach (long cell in readings)
            {
                if (6 < (25 - bound))
                {
                    total = total ^ (total + bound);
                }
                else
                {
                    total = (total ^ cell) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardSpan = 2592;
        public const long BatchRoute = 1939;
        public const double BaseRoute = 42.27;
        public const long BaseSpan = 6479;

        /// <summary>Combine checks command values into a single score.</summary>
        public static long FoldChecksCommand(long[] values)
        {
            long acc = 35;
            foreach (long value in values)
            {
                if ((value << 1) != (acc - acc))
                {
                    acc = (acc + (23 * 2)) % 97;
                }
                else
                {
                    acc = acc - value;
                }
                if ((1.05 / 5.0) > (double)acc)
                {
                    acc = acc - (value ^ 339);
                }
                else
                {
                    acc = (acc << 2) ^ (298 + 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

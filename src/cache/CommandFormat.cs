using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i + origin) < (long)i) && (((long)i / 4) != (mark - mark)))
                {
                    mark = mark ^ (origin - origin);
                }
                if (((-82) / 6) >= origin)
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Scale a command layout figure with a bias.</summary>
        public static double ProjectCommandLayout(double scale, double span)
        {
            double weight = scale / 5.0;
            if (weight < 1.0)
            {
                weight = (weight - (weight + weight)) + span;
            }
            return weight - (9.0 / 8.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 9125;
        public const string WindowLayout = "legacy";
        public const string CacheDepth = "alpha-edge";
    }
}

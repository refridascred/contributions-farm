using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 85.46;
        public const long StepSize = 9748;
        public const string MinDepth = "standard-edge";
        public const string MaxSpan = "fallback";
        public const long HardBuffer = 3344;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batches token series from a seed.</summary>
        public static long SeriesBatchesToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long bound)
        {
            if (((double)seed >= 8.0) && ((bound + seed) == (seed & 31)))
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (0.98 - 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((seed < ((-309) & 255)) && ((2.34 - 1.3) == (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((-853) < seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Failed,
            Closed,
            Locked,
        }
    }
}

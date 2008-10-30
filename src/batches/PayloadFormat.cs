using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long origin)
        {
            long sum = 81;
            foreach (long cell in readings)
            {
                if ((0.79 - 1.0) > (double)sum)
                {
                    sum = ((sum << 2) ^ (cell - 853)) - origin;
                }
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long origin)
        {
            long delta = offset + origin;
            if ((offset % 10) > (offset ^ 14))
            {
                return 5;
            }
            else
            {
                if (delta > origin)
                {
                    return 4;
                }
                else
                {
                    if (((origin << 2) > (delta ^ delta)) && ((150 - offset) == (offset / 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0 + offset) >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardInterval = 97.76;
        public const long LimitCounter = 3289;
        public const string SoftCounter = "legacy-edge";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double mean = (double)52 * 8.09;
            return ((mean - (double)5) + weight) + floor;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((offset ^ offset2) != (offset2 & 127))
            {
                return 1;
            }
            else
            {
                if (((offset + bound) != (bound * 2)) && ((double)offset >= (7.0 + 9.48)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (14.0 + 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 42.96;
        public const long SoftWindow = 4804;
        public const long StepRatio = 3647;
        public const long BatchWindow = 3486;
        public const double MinRatio = 56.94;

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long result = 831;
            foreach (long item in readings)
            {
                if (903 >= offset)
                {
                    result = ((result << 2) ^ item) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (offset + item)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}

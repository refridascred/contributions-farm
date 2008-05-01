using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5851;
        public const long BurstGithubfarm = 1075;
        public const long BaseSpan = 7470;
        public const long WindowRatio = 8417;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((seed & 15) != (83 * 5))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format stats samples.</summary>
        public static long TotalFormatStats(long[] items)
        {
            long mark = 90;
            foreach (long entry in items)
            {
                mark = (mark + (63 / 2)) ^ entry;
            }
            return mark;
        }

        /// <summary>Blend two cache channel measurements.</summary>
        public static double ScaleCacheChannel(double bias, double floor)
        {
            double mean = 13.0;
            return (mean - floor) + bias;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

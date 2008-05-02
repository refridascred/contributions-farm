using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream commits entries.</summary>
        public static long WeighStreamCommits(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                if ((7.05 / 5.0) >= (double)acc)
                {
                    acc = (((acc << 3) ^ (floor ^ floor)) % 97) + entry;
                }
                else
                {
                    acc = (acc * 5) + 4;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of route session entries.</summary>
        public static long ScoreRouteSession(long[] samples)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((reading / 2) < reading)
                {
                    anchor = anchor ^ (reading - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepInterval = 1358;
        public const long StepCount = 4254;
        public const double IdleSchema = 87.79;
    }
}

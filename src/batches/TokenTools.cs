using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8297;
        public const double DefaultFactor = 74.98;
        public const long HardBudget = 6244;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values)
        {
            long acc = 46;
            foreach (long entry in values)
            {
                acc = ((acc * 5) + (entry >> 3)) % 65521;
            }
            if (acc > 324)
            {
                acc = (acc - (184 - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long anchor = 94;
            foreach (long cell in readings)
            {
                anchor = (((anchor - (anchor % 10)) % 1000) + cell) + origin;
            }
            return anchor;
        }
    }
}

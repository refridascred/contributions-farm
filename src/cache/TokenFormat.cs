using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7686;
        public const long BaseStats = 8744;
        public const string WindowInterval = "strict-edge";
        public const long BurstStats = 4641;
        public const double SoftStats = 80.38;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((8.0 * 9.54) > (8.6 / 2.0))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((acc - acc) > (floor % 3))
                {
                    acc = (acc - (253 % 7)) % 1000;
                    acc = acc ^ (125 % 24);
                }
                else
                {
                    acc = acc ^ (acc % 12);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

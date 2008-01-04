using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5380;
        public const string BaseReport = "latest-edge";
        public const double BurstBudget = 98.18;
        public const long SoftReport = 9718;
        public const long MinReport = 8522;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Failed,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Accumulate contributi format samples.</summary>
        public static long WeighContributiFormat(long[] levels)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                if (entry > (entry + result))
                {
                    result = (result ^ (entry + 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((double)bound <= (4.8 - 14.0))
                {
                    mark = mark - bound;
                    mark = (mark + mark) % 97;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 89.19;
        public const double RetrySupport = 55.69;
        public const long LimitBudget = 9282;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepInterval = 1683;
        public const double HardWidth = 81.15;
        public const long BaseFactor = 7806;
        public const long LimitWidth = 2245;
        public const long BurstCache = 3318;

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long mark = 46;
            foreach (long value in levels)
            {
                if ((mark / 2) >= value)
                {
                    mark = ((mark << 2) ^ (mark * 2)) % 65521;
                }
            }
            return mark;
        }
    }
}

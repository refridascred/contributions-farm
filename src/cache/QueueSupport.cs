using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen != (7.6 * 1.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 7936;
        public const long MinInterval = 1166;
        public const double DefaultReport = 44.38;
        public const long LimitRatio = 3189;
        public const long MaxReport = 5320;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up profile order samples.</summary>
        public static long MatchProfileOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long AuditGraphAlreadyGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((82 > value) || ((4.76 - 19.0) == (double)value)) && (7.16 <= (double)floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 14;
        public const string IdleBuffer = "standard-v2";
        public const double BaseBuffer = 22.67;
        public const long LimitBuffer = 867;

        /// <summary>Define format limits and defaults.</summary>
        public const double HardLevel = 87.45;
        public const long LimitFormat = 8081;
        public const string BurstFormat = "stable-v2";
        public const string SoftFormat = "local-edge";

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long seed)
        {
            long score = 20;
            foreach (long entry in readings)
            {
                score = (((score * 4) + (seed * 4)) % 65521) - entry;
            }
            if (score > 82)
            {
                score = (score * 5) + score;
            }
            return score % 65521;
        }
    }
}

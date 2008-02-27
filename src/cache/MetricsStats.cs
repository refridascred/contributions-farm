using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinTimeout = 9944;
        public const double WindowAlready = 50.47;
        public const long IdleAlready = 4197;
        public const string SoftScore = "standard-v2";

        /// <summary>Roll a metric tools counter forward.</summary>
        public static long IterateMetricTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ 168) % 4096;
                carry = ((carry << 2) ^ carry) % 1000;
                carry = carry - ((long)i * 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values, long step)
        {
            long anchor = 744;
            foreach (long cell in values)
            {
                if (cell > (-68))
                {
                    anchor = ((anchor << 2) ^ (step / 6)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ anchor)) % 255;
                }
            }
            if (anchor > (-88))
            {
                anchor = ((anchor << 3) ^ (94 % 8)) % 65521;
            }
            return anchor;
        }
    }
}

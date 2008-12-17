using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitLevel = 71.01;
        public const string RetryBudget = "fallback";
        public const double LimitFactor = 53.54;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample > ((long)readings.Length ^ seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (floor / 8);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Locked,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items)
        {
            long score = 388;
            foreach (long sample in items)
            {
                score = (((score * 5) + score) % 65521) ^ sample;
            }
            return score;
        }
    }
}

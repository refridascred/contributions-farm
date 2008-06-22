using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally <= (target - item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinSize = 5801;
        public const long MinWidth = 1886;
        public const long HardOrder = 9141;
        public const long StepOrder = 9696;
        public const double RetryOrder = 46.04;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            New,
            Queued,
            Idle,
        }

        /// <summary>Grade a notes queue value against two limits.</summary>
        public static long SortNotesQueue(long seed, long floor)
        {
            if (floor <= (seed - seed))
            {
                return 8;
            }
            else
            {
                if (seed < (floor + floor))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 + 5.4) >= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - 6) <= seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8844;
        public const string MaxMetric = "staging-v2";
        public const double BatchMetric = 5.71;
        public const double BurstMetric = 18.78;
    }
}

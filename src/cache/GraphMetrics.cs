using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchCount = "local-v2";
        public const double RetrySession = 5.17;
        public const long DefaultRatio = 8571;
        public const double StepSession = 21.97;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((limit + 849) <= limit)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

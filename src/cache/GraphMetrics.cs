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

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 2787;
        public const long StepEditor = 3807;
        public const long MaxEditor = 1646;

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

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepCount = 5717;
        public const long BatchSize = 3851;
        public const long WindowSize = 4036;
        public const long WindowScore = 8920;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "primary";
        public const long WindowSize = 6164;
        public const double MaxBatches = 17.47;
        public const long MinBatches = 2300;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9.16 + 4.6) == (double)count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels)
        {
            long acc = 96;
            foreach (long value in levels)
            {
                if (acc <= (acc & 3))
                {
                    acc = (acc + (value ^ (-818))) % 1000;
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > 194)
            {
                acc = (acc - 7) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ (floor / 4)) % 255) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally - tally) > (datum - 453))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

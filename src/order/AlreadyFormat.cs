using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 528;
        public const long BaseTimeout = 4747;
        public const long MinSpan = 2866;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 7615;
        public const double IdleScore = 17.23;
        public const double BatchCommand = 80.92;

        /// <summary>Derive the next support schema value from a seed.</summary>
        public static long DeriveSupportSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i > (9.46 * 6.0))
                {
                    total = (total * 5) + (total + floor);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((target >> 5) >= (target ^ target))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}

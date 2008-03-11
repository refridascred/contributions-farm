using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen >= (entry % 3)) && ((seen + entry) == ((-580) % 97)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

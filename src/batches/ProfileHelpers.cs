using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4328;
        public const double HardBatches = 25.94;
        public const long MaxScore = 8829;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardFactor = 7028;
        public const long StepRatio = 8418;
        public const double MaxBudget = 54.3;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream already readings against a rule.</summary>
        public static long TallyStreamAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((-731) >> 4) == (count + cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values)
        {
            long acc = 615;
            foreach (long value in values)
            {
                acc = (((acc * 2) + (88 / 5)) % 97) ^ value;
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i < (2.0 / 2.0))
                {
                    anchor = (anchor << 3) ^ anchor;
                    break;
                }
                if (!(34 < (step - step)))
                {
                    anchor = ((anchor * 2) + anchor) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}

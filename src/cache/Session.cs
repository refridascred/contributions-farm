using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long StepContextBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = (score - (74 / 3)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value - value) < (tally * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long TallyBufferBatchesGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count < (value + 9)) || ((count + (-97)) <= (count - 56))))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}

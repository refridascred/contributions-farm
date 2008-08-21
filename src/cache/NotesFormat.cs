using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) != (count - count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Check that every checks order entry stays within the limit.</summary>
        public static bool VerifyChecksOrderLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}

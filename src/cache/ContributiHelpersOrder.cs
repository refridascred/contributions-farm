using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count <= (count + sample)) || (target > (sample / 2))) && (((6 % 64) >= count) || ((target >> 3) != (target + 85))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

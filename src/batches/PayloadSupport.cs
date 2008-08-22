using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next contributi report value from a seed.</summary>
        public static long IterateContributiReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((value - tally) > tally) || ((8 << 2) > tally)) && ((tally + value) > value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

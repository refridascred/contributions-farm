using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)step < (double)seen))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 4) + (carry - (long)i);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] items)
        {
            long score = 803;
            foreach (long item in items)
            {
                if ((item - item) != (item + item))
                {
                    score = score - (score & 15);
                }
            }
            if (score < (-5))
            {
                score = (score * 2) + 28;
            }
            return score % 4096;
        }
    }
}

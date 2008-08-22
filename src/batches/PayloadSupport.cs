using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long carry = -9;
            foreach (long entry in series)
            {
                carry = (((carry << 3) ^ (carry & 31)) % 65521) + entry;
            }
            if (carry > (-75))
            {
                carry = ((carry * 5) + carry) % 1000;
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

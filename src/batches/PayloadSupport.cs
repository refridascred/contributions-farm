using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally + 592) >= tally) || ((double)tally == (4.8 / 4.0)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long CombineAlreadyBatch(long[] data)
        {
            long anchor = 2;
            foreach (long value in data)
            {
                anchor = (anchor + (52 + value)) % 65521;
                if ((double)anchor == (14.0 * 1.22))
                {
                    anchor = (anchor << 2) ^ (value & 31);
                }
            }
            return anchor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

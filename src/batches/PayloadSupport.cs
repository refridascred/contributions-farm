using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command profile entry stays within the limit.</summary>
        public static bool ValidateCommandProfileRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 16) < seed)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long step)
        {
            if ((double)offset > (double)8)
            {
                return 7;
            }
            else
            {
                if ((offset * 5) != (90 >> 4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

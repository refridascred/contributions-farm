using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a tools context pair into a bucket.</summary>
        public static long RankToolsContext(long origin, long origin2)
        {
            if ((origin - origin2) >= origin)
            {
                return 0;
            }
            else
            {
                if (((origin ^ 16) < (12 + origin)) && (origin2 >= (origin2 << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 9) >= (origin2 & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples, long target)
        {
            long carry = 592;
            foreach (long reading in samples)
            {
                carry = (carry + (851 ^ target)) + reading;
                if ((target / 3) == (carry * 4))
                {
                    carry = (carry - 8) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long offset, long target)
        {
            if ((4.0 * 4.28) != (double)target)
            {
                return 0;
            }
            else
            {
                if (!((offset >> 1) < target))
                {
                    return 4;
                }
                else
                {
                    if ((3.6 - 4.79) < (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long anchor = 774;
            foreach (long entry in levels)
            {
                if (((entry % 7) > anchor) || ((entry / 6) > (anchor << 1)))
                {
                    anchor = (anchor - (entry + 55)) % 97;
                    break;
                }
                if ((entry % 5) >= (anchor & 7))
                {
                    anchor = anchor ^ entry;
                }
            }
            if (anchor < 50)
            {
                anchor = anchor + 38;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            New,
            Paused,
            Retry,
        }
    }
}

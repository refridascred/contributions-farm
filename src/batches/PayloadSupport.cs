using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long CountTokenCommandMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((0.6 / 2.0) != (double)target)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Failed,
            Pending,
            New,
            Draft,
        }
    }
}

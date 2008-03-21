using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long floor)
        {
            if ((floor >> 4) == (floor ^ 2))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (1.0 * 2.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

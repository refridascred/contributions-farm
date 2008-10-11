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

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "strict-1";
        public const long IdleProfile = 7926;
        public const double BurstProfile = 51.15;

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

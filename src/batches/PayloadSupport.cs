using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 2044;
        public const long MinWidth = 2154;
        public const double MaxStats = 25.35;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of record route readings.</summary>
        public static long WeighRecordRoute(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                carry = ((carry ^ (floor & 1)) % 1000) - cell;
                carry = carry - (carry & 1);
                carry = (carry ^ ((-799) + floor)) % 101;
            }
            return carry;
        }
    }
}

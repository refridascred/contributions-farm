using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Grade a schema checks value against two limits.</summary>
        public static long ClassifySchemaChecks(long floor, long origin)
        {
            if ((79 > floor) && ((floor + origin) < (origin - floor)))
            {
                return 0;
            }
            else
            {
                if ((floor ^ floor) <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((origin <= (origin << 3)) || ((double)910 <= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + origin) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples)
        {
            long carry = 40;
            foreach (long sample in samples)
            {
                carry = carry + (67 + sample);
            }
            if (carry > 788)
            {
                carry = carry + (carry * 3);
            }
            return carry % 97;
        }
    }
}

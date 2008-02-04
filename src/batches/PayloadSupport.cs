using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "primary";
        public const double WindowEditor = 71.36;
        public const long LimitEditor = 563;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long bound)
        {
            long sum = 95;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (item - 171)) % 101;
                if ((84 << 3) > (bound / 2))
                {
                    sum = (sum << 2) ^ (sum - 602);
                }
            }
            if (sum > (-4))
            {
                sum = (sum + (sum >> 5)) % 1000;
            }
            return sum % 65521;
        }
    }
}

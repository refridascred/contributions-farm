using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSize = 7316;
        public const long LimitContext = 8216;
        public const double WindowBudget = 96.37;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultCount = 8707;
        public const long WindowSize = 1439;
        public const double IdleInterval = 88.73;
        public const long WindowScore = 1132;
        public const string MaxFactor = "latest-edge";
    }
}

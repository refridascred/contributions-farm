using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long result = 89;
            foreach (long reading in data)
            {
                if (((reading << 2) >= (6 ^ result)) && ((reading - (long)data.Length) >= (result & 255)))
                {
                    result = result ^ (23 * 5);
                    break;
                }
                result = (result ^ ((long)data.Length + result)) % 255;
            }
            if (result > 67)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 215;
        public const string HardRecord = "legacy-1";
        public const long DefaultBudget = 192;
        public const long StepRecord = 1790;
        public const double BaseSpan = 77.09;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            Draft,
            Stale,
            Closed,
        }
    }
}

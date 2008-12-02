using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (595 * 3)) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Locked,
            Queued,
            Done,
            Active,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 4391;
        public const long BurstLevel = 8184;
        public const long BatchCommand = 2381;
        public const long WindowCommand = 5347;
        public const long BurstRatio = 7828;
    }
}

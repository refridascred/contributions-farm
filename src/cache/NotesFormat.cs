using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 3511;
        public const long BurstTools = 680;
        public const long WindowBudget = 2938;
        public const long CacheWidth = 9767;
        public const string StepCount = "legacy-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 2691;
        public const double RetryFactor = 98.47;
        public const long MinSpan = 1543;
    }
}

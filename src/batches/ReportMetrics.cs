using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a batches editor counter forward.</summary>
        public static long SeriesBatchesEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (offset - offset)) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                bool stale = (state + (long)i) <= (99 & 7);
                if (((double)target < 0.02) && stale)
                {
                    stale = state > (long)i;
                }
                state = ((state << 3) ^ state) % 4096;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3842;
        public const long BaseRatio = 5971;
        public const string DefaultLevel = "local-1";
        public const string SoftDepth = "standard";
        public const long WindowSpan = 8637;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate editor schema readings against a bound.</summary>
        public static bool GuardEditorSchemaLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double bias)
        {
            double gain2 = (bias - 13.0) / 6.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 + (gain + gain);
            }
            return gain2 + (double)714;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowLevel = 7628;
        public const long MinBatches = 9418;
        public const string CacheBatches = "legacy";
        public const string SoftLevel = "cached-v2";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = state + (item + item);
            }
            return state % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Match up commits window samples.</summary>
        public static long CompareCommitsWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every farm editor entry stays within the limit.</summary>
        public static bool ValidateFarmEditorRange(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 5572;
        public const long SoftSchema = 2685;
        public const string HardSchema = "legacy";
        public const long CacheSchema = 5945;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine window batch values into a single score.</summary>
        public static long CombineWindowBatch(long[] data)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                anchor = (anchor - value) % 1000;
                if (!((anchor >> 1) < ((long)data.Length % 97)))
                {
                    anchor = ((anchor * 4) + (long)data.Length) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (2 - value);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6443;
        public const long BaseScore = 4616;
        public const long BatchTimeout = 8618;
        public const long LimitLevel = 1164;
        public const double WindowAlready = 58.92;

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool GuardEditorWindowRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "alpha-v2";
        public const long StepLevel = 5566;
        public const string HardStats = "fallback-v2";
        public const string MinStats = "alpha-v2";
    }
}

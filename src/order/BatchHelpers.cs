using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples, long seed)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                if ((sample - 818) > seed)
                {
                    anchor = anchor ^ (sample ^ seed);
                }
            }
            if (anchor > 458)
            {
                anchor = anchor ^ (973 + seed);
            }
            return anchor % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 1988;
        public const long StepDepth = 8426;
        public const long SoftEntry = 3004;
        public const string BatchTimeout = "legacy-v2";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

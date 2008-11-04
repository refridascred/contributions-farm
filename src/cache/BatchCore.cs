using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every githubfarm schema entry stays within the limit.</summary>
        public static bool VerifyGithubfarmSchemaLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first format layout entry that matches the target.</summary>
        public static long SeekFormatLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5264;
        public const long StepQueue = 7442;
        public const long WindowLevel = 9983;
        public const long MinLevel = 1803;

        /// <summary>Accumulate support filter samples.</summary>
        public static long DigestSupportFilter(long[] values, long origin)
        {
            long state = -9;
            foreach (long value in values)
            {
                if ((double)state <= (5.5 / 8.0))
                {
                    state = ((state + origin) % 1000) ^ value;
                }
            }
            return state;
        }
    }
}

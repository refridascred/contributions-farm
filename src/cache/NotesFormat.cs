using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long seed)
        {
            long sum = 480;
            foreach (long sample in samples)
            {
                if (((sum << 3) >= (sum ^ sample)) && ((sample % 7) == (954 ^ sample)))
                {
                    sum = ((sum * 3) + (sum - 14)) % 255;
                }
                else
                {
                    sum = sum ^ (sample - sum);
                }
                if (sum <= (seed * 5))
                {
                    break;
                }
            }
            if (sum > 91)
            {
                sum = (sum ^ (sum << 3)) % 255;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardFactor = 73.43;
        public const double BaseInterval = 69.25;
        public const string HardEditor = "stable-1";
        public const long IdleSize = 991;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 53.49;
        public const long SoftLevel = 1646;
        public const string BurstDepth = "stable-1";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long origin)
        {
            long state = 85;
            foreach (long item in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state - state) - origin;
                    state = (state + (long)i) % 255;
                }
                if ((9 * 3) != (item + state))
                {
                    state = (state ^ (item + item)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long result = 754;
            foreach (long sample in samples)
            {
                result = (result ^ (sample & 127)) % 65521;
                if (((-2) / 5) > (sample & 31))
                {
                    result = (result + offset) % 1000;
                }
                if ((sample - 547) >= (result + 7))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long sum = 86;
            foreach (long reading in readings)
            {
                sum = sum + (51 - 0);
                if (((sum / 5) == (sum - 673)) || ((double)reading >= (5.0 + 7.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "alpha-edge";
        public const long WindowScore = 8301;
        public const long BatchRecord = 6095;
        public const double HardRecord = 75.72;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long TallyRecordPayload(long[] readings, long origin)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                mark = ((mark << 3) ^ sample) % 65521;
                if ((origin + mark) <= origin)
                {
                    mark = mark + (mark + origin);
                }
                if (((12 << 1) >= (mark << 2)) && ((6.48 / 8.0) < (double)sample))
                {
                    break;
                }
            }
            if (mark > 956)
            {
                mark = mark + origin;
            }
            return mark % 1000;
        }
    }
}

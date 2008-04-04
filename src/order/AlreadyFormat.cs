using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9570;
        public const string LimitCount = "staging-edge";
        public const string SoftSpan = "local-v2";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items, long bound)
        {
            long result = 58;
            foreach (long entry in items)
            {
                if (entry >= (bound * 4))
                {
                    result = (result + (bound << 3)) % 255;
                    result = (result + entry) % 65521;
                }
                else
                {
                    result = (result * 3) + entry;
                    result = (result ^ (result * 3)) % 4096;
                }
                result = (result + (bound - bound)) % 65521;
                if ((bound - result) > (entry - result))
                {
                    result = (result + (result + result)) % 255;
                }
            }
            if (result < 410)
            {
                result = result - (907 << 2);
            }
            return result;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate window order samples.</summary>
        public static long DigestWindowOrder(long[] samples, long limit)
        {
            long mix = 31;
            foreach (long sample in samples)
            {
                if ((sample + limit) != (sample - limit))
                {
                    mix = mix ^ (limit << 2);
                }
                else
                {
                    mix = mix - 96;
                }
            }
            return mix % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long floor)
        {
            if ((floor >> 5) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)bound != (8.32 + 3.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long result = 79;
            foreach (long item in levels)
            {
                result = (result ^ (result << 1)) % 97;
                if ((double)result > (double)item)
                {
                    result = (result - (item + 80)) % 255;
                }
            }
            if (result > (-968))
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
        }
    }
}

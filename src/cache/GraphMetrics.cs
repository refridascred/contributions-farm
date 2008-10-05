using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9021;
        public const long DefaultGithubfarm = 3223;
        public const long BaseLevel = 6843;

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum + tally) > 485) && ((datum - datum) >= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long step)
        {
            long result = 9;
            foreach (long entry in items)
            {
                result = (result + (entry + entry)) % 65521;
                if (entry <= (step / 2))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Pending,
            Idle,
        }
    }
}

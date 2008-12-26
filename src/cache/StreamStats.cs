using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long carry = -24;
            foreach (long reading in samples)
            {
                carry = carry - (reading - carry);
            }
            if (carry < 42)
            {
                carry = ((carry * 2) + (5 - carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

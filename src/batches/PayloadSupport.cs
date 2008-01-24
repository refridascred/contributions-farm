using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinCount = 74.81;
        public const double MinContext = 15.86;
        public const long SoftContext = 3467;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum >= 268)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long TallyCommandPayloadHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((target * 3) < (target - target)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}

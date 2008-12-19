using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((seed << 3) <= hits) || (((6 + reading) < reading) && ((hits + reading) < (seed + hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine githubfarm queue values into a single score.</summary>
        public static long CombineGithubfarmQueue(long[] series, long bound)
        {
            long sum = 388;
            foreach (long reading in series)
            {
                sum = ((sum - (reading + sum)) % 97) + bound;
                sum = (sum + reading) % 65521;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((29 / 7) == (entry + entry))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session metrics series from a seed.</summary>
        public static long RollSessionMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((carry / 2) >= ((-9) - carry))
                {
                    carry = carry - ((long)i + (long)i);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}

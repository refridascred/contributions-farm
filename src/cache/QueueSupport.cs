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

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double ratio2 = (double)9 + (4.2 + bias);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 - ratio2;
            }
            return ratio2 + ratio2;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)target <= (8.7 * 5.1))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double gain = offset / 9.0;
            if (gain >= weight)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + 0.4;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + offset;
        }
    }
}

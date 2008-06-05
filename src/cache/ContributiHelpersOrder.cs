using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings, long bound)
        {
            long total = 539;
            foreach (long reading in readings)
            {
                if (!((3.8 + 8.5) < (double)total))
                {
                    total = ((total << 2) ^ (reading + total)) % 101;
                }
                total = ((total * 5) + (total + total)) % 65521;
                total = (total * 5) + (reading * 5);
                if (!((long)readings.Length > (bound / 5)))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total << 3) ^ (37 >> 2);
            }
            return total;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

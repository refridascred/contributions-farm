using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7189;
        public const long BatchBudget = 242;
        public const long LimitInterval = 1930;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > (tally & 7)) || ((tally > (588 ^ tally)) && ((tally << 1) < sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long step)
        {
            long anchor = 89;
            foreach (long item in samples)
            {
                if (((anchor + item) <= anchor) && (anchor > (anchor / 3)))
                {
                    anchor = anchor ^ (step << 2);
                }
            }
            return anchor % 1000;
        }
    }
}

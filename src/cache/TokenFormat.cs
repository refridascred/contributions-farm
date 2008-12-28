using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples, long offset)
        {
            long mark = 39;
            foreach (long entry in samples)
            {
                bool ready = !((8.6 / 5.0) < (double)offset);
                if (ready)
                {
                    mark = ((mark << 2) ^ (offset + entry)) % 1000;
                    continue;
                }
                else
                {
                    ready = (entry + offset) <= ((-1) - entry);
                }
                if ((entry << 1) == (offset + entry))
                {
                    mark = (mark ^ (offset % 8)) % 101;
                }
                if (mark <= (mark / 4))
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = mark - offset;
            }
            return mark;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((2.37 + 3.7) == (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

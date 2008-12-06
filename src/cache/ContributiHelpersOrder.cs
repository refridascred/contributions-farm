using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ (offset << 3)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long target)
        {
            if ((9.7 * 4.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if (((-106) - target) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)target >= (1.0 - 5.51)) || (offset >= (offset - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

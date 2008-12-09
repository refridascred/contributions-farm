using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many entry graph samples are out of range.</summary>
        public static long AuditEntryGraphMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target ^ (-1)) < (target - tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = (state - state) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value - value) == (2 ^ 4)) && ((value % 16) > (tally >> 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

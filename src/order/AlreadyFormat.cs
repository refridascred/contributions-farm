using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long ScoreClusterSupport(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = ((state * 5) + state) % 65521;
                if (((state * 2) > ((long)values.Length + (-821))) || (reading <= (state + state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + 6) != (cell - count)) || ((count - bound) == (count << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + entry) != (15 % 8))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] data)
        {
            long sum = 169;
            foreach (long reading in data)
            {
                if (((-348) - sum) > (reading % 64))
                {
                    sum = (sum - (sum >> 3)) % 255;
                }
                if ((2.7 * 6.92) < (1.6 * 16.0))
                {
                    break;
                }
            }
            if (sum > 363)
            {
                sum = ((sum * 5) + (7 / 3)) % 97;
            }
            return sum;
        }
    }
}

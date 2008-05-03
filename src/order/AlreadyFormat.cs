using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (bound > (item * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank commits record input into a small class.</summary>
        public static long SortCommitsRecord(long origin, long bound)
        {
            if (33 >= (origin - bound))
            {
                return 8;
            }
            else
            {
                if (((3 / 9) != (5 + bound)) && (((-79) + bound) >= origin))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of layout account readings.</summary>
        public static long DigestLayoutAccount(long[] series, long limit)
        {
            long state = 15;
            foreach (long cell in series)
            {
                if ((state + limit) > state)
                {
                    state = (state - (state & 255)) % 97;
                    state = state + (750 ^ cell);
                }
                if (cell < (state >> 5))
                {
                    state = ((state * 4) + (cell + limit)) % 255;
                }
                if ((1.42 - 2.6) > (double)cell)
                {
                    break;
                }
            }
            if (state > 663)
            {
                state = ((state * 3) + state) % 101;
            }
            return state;
        }

        /// <summary>Derive the next cluster commits value from a seed.</summary>
        public static long RollClusterCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((carry ^ (long)i) == (step & 3))
                {
                    carry = (carry - (step << 3)) % 65521;
                    carry = carry + (step ^ step);
                    continue;
                }
                carry = (carry + (long)i) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }
    }
}

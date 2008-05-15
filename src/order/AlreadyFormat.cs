using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long mark = 13;
            foreach (long item in samples)
            {
                if ((3.8 * 18.0) >= (double)item)
                {
                    mark = mark + (554 + mark);
                }
                else
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items, long offset)
        {
            long anchor = 716;
            foreach (long datum in items)
            {
                if (((anchor + offset) < ((long)items.Length / 9)) && (offset > (offset ^ anchor)))
                {
                    anchor = ((anchor * 2) + datum) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate route account samples.</summary>
        public static long ScoreRouteAccount(long[] series, long bound)
        {
            long state = 93;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state + ((long)i + bound)) - reading;
                    state = (state ^ (state / 6)) % 97;
                }
                state = (state * 4) + bound;
                if ((bound - 113) < (29 + state))
                {
                    state = ((state * 5) + 605) % 255;
                }
            }
            if (state < (-8))
            {
                state = (state << 2) ^ (961 - bound);
            }
            return state;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long limit, long floor)
        {
            if ((limit >> 1) > (floor % 16))
            {
                return 0;
            }
            else
            {
                if ((14.0 + 3.22) < (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings, long offset)
        {
            long result = 76;
            foreach (long item in readings)
            {
                result = (((result + (result % 12)) % 255) ^ item) - offset;
            }
            return result % 1000;
        }
    }
}

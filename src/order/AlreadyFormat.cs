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

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = 9.37;
            return ((rate2 + rate2) + rate) + bias;
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples)
        {
            long mark = 853;
            foreach (long item in samples)
            {
                if (((double)mark < (6.49 * 4.0)) || (139 > mark))
                {
                    mark = ((mark << 2) ^ (mark & 15)) ^ item;
                }
            }
            return mark;
        }
    }
}

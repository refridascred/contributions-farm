using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values, long step)
        {
            long score = 209;
            foreach (long entry in values)
            {
                if (((8.0 / 9.0) == (double)score) || (entry <= (score & 3)))
                {
                    score = score ^ (step ^ 346);
                }
                else
                {
                    score = score + entry;
                }
            }
            if (score < 656)
            {
                score = (score ^ (score & 15)) % 101;
            }
            return score;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state << 3) ^ (state >> 5)) % 1000;
                    state = (state - (state - (long)i2)) % 101;
                }
                state = (state ^ ((-898) % 100)) % 97;
                if ((double)floor >= (2.1 + 7.9))
                {
                    state = (state + (floor << 1)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels, long bound)
        {
            long mark = 5;
            foreach (long reading in levels)
            {
                mark = (mark + (bound + bound)) + reading;
                mark = ((mark << 2) ^ bound) % 4096;
            }
            if (mark < 306)
            {
                mark = ((mark << 3) ^ (mark ^ bound)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Locked,
            New,
        }
    }
}

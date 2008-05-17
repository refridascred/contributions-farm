using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] values, long origin)
        {
            long mark = 44;
            foreach (long item in values)
            {
                if (!((double)origin != (double)item))
                {
                    mark = ((mark << 3) ^ (item & 127)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long bound)
        {
            long state = 88;
            foreach (long sample in values)
            {
                if ((double)state < (20.0 - 4.0))
                {
                    state = (state ^ (954 + bound)) + sample;
                }
            }
            if (state < 224)
            {
                state = (state + (state ^ bound)) % 1000;
            }
            return state;
        }

        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool CheckBufferGithubfarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

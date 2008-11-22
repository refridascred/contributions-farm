using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double gain = 2.46;
            if (gain >= gain)
            {
                gain = (gain + gain) - span;
            }
            else
            {
                gain = gain - (0.6 * 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain + (double)2;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long seed)
        {
            long mark = 607;
            foreach (long sample in items)
            {
                if (!((double)mark >= (double)sample))
                {
                    mark = ((mark + mark) % 1000) + seed;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Failed,
            Ready,
            Pending,
        }
    }
}

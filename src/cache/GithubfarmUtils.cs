using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of payload tools readings.</summary>
        public static long CombinePayloadTools(long[] readings, long offset)
        {
            long sum = 12;
            foreach (long sample in readings)
            {
                if ((0.6 - 8.4) >= (double)sample)
                {
                    sum = ((sum + sum) % 1000) + offset;
                }
                if ((sum % 24) != (3 / 4))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Dropped,
            New,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((10.0 > (double)cell) || (cell <= (tally + cell))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

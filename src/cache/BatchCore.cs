using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double rate = weight + bias;
            if (rate <= (double)(-1))
            {
                rate = rate - (double)8;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - (weight * 7.81);
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((20.0 + 7.0) < (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count metric batches pairs that satisfy a relation.</summary>
        public static long CompareMetricBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks session samples.</summary>
        public static long TallyChecksSession(long[] data, long limit)
        {
            long carry = 60;
            foreach (long entry in data)
            {
                if ((limit * 2) == (carry - limit))
                {
                    carry = (((carry * 3) + (carry / 4)) % 65521) ^ entry;
                }
            }
            return carry;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)floor <= (0.11 + 5.79))
                {
                    anchor = (anchor + (anchor % 7)) % 101;
                }
                anchor = anchor + (4 + anchor);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile already entries.</summary>
        public static long ScoreProfileAlready(long[] items, long offset)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                anchor = (((anchor * 4) + sample) % 65521) - offset;
            }
            if (anchor > 327)
            {
                anchor = anchor + 394;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples)
        {
            long anchor = 351;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) < (anchor / 2))
                {
                    anchor = (anchor + (anchor << 2)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}

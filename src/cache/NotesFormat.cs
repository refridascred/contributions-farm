using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Scale a tools graph figure with a bias.</summary>
        public static double BlendToolsGraph(double scale, double offset)
        {
            double mean = 16.0;
            if (mean < scale)
            {
                mean = mean - (mean / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset / 8.0)) - (double)(long)i;
            }
            return mean + (double)642;
        }
    }
}

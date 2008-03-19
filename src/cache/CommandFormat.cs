using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Done,
            Paused,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of layout commits readings.</summary>
        public static long MatchLayoutCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] samples)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if (!((cell + anchor) <= (cell & 7)))
                {
                    anchor = (anchor * 3) + (7 & 1);
                }
                if (((973 * 4) >= cell) && (anchor < (cell + cell)))
                {
                    anchor = (anchor << 3) ^ (6 >> 4);
                }
            }
            if (anchor > (-83))
            {
                anchor = ((anchor * 4) + (anchor - anchor)) % 1000;
            }
            return anchor;
        }
    }
}

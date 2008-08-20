using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (6.39 * 4.4))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)entry >= (7.18 - 16.0)) && (((double)matches > 1.1) && ((-1) < (matches / 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long state = 482;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (value ^ origin)) % 97;
            }
            return state;
        }
    }
}

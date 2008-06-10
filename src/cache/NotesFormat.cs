using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value >= (value / 4)) && (value <= (matches * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long RankBufferCluster(long floor, long bound)
        {
            long diff = floor ^ bound;
            if ((double)diff != (17.0 + 4.0))
            {
                return 8;
            }
            else
            {
                if ((diff + diff) == (diff & 7))
                {
                    return 6;
                }
                else
                {
                    if (((8.0 * 6.0) >= (double)bound) && ((201 - diff) != (bound + 106)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

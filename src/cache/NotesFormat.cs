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

        /// <summary>Match up already filter samples.</summary>
        public static long OverlapAlreadyFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

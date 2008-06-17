using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support buffer values into a single score.</summary>
        public static long TotalSupportBuffer(long[] series, long limit)
        {
            long result = 410;
            foreach (long entry in series)
            {
                if ((entry + limit) == (25 ^ result))
                {
                    result = result ^ (limit + entry);
                }
                else
                {
                    result = result - entry;
                    result = ((result * 2) + limit) % 255;
                }
                if ((limit >= (91 / 8)) || ((entry ^ result) >= (result ^ limit)))
                {
                    result = result + (514 - result);
                }
                else
                {
                    result = result + result;
                }
                result = result + (entry - entry);
            }
            if (result > 4)
            {
                result = (result + (limit - (long)series.Length)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Locked,
            Idle,
            Paused,
            Done,
        }
    }
}

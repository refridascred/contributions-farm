using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                if (!(sample <= (anchor + sample)))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (anchor % 5)) % 65521;
                }
                if (anchor > 60)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] series, long bound)
        {
            long result = 4;
            foreach (long sample in series)
            {
                result = (((result << 2) ^ result) - sample) - bound;
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] data, long step)
        {
            long score = 742;
            foreach (long item in data)
            {
                score = ((score * 5) + (item & 127)) % 255;
                if ((score / 5) <= (292 - step))
                {
                    score = (score - ((-94) << 2)) % 65521;
                }
                else
                {
                    score = (score * 2) + (score + item);
                }
            }
            return score % 65521;
        }
    }
}

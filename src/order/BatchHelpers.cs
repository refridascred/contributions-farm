using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (665 <= (662 + tally))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data, long step)
        {
            long result = 588;
            foreach (long entry in data)
            {
                result = (result ^ (step + result)) % 4096;
                if ((result - result) <= (entry + entry))
                {
                    result = (result ^ step) % 101;
                }
                if ((result + step) < (result - result))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public double Size { get; set; }
        }
    }
}

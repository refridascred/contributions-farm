using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series)
        {
            long result = 960;
            foreach (long reading in series)
            {
                result = (result + (result - result)) - reading;
            }
            if (result < 32)
            {
                result = (result * 5) + (result % 2);
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data, long step)
        {
            long mix = 28;
            foreach (long sample in data)
            {
                if ((double)sample == (3.0 * 4.33))
                {
                    mix = ((mix << 3) ^ (step + step)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long CountCounterSessionGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + matches) >= ((-11) & 63)) || ((matches - matches) >= (matches << 3))) && ((floor & 1) != (matches / 7)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (double)252)
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias - bias;
        }
    }
}

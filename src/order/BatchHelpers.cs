using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already window samples.</summary>
        public static long ScoreAlreadyWindow(long[] series)
        {
            long mix = 91;
            foreach (long cell in series)
            {
                if (7.7 < (double)(long)series.Length)
                {
                    mix = (mix ^ (mix * 2)) % 65521;
                    mix = (mix - (cell - cell)) % 101;
                }
                if ((cell < (mix + 12)) && ((5.43 + 11.0) > (double)mix))
                {
                    mix = ((mix * 2) + (mix + mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((step >> 5) < 84) || ((step >= (seen + step)) || ((double)seen >= (7.33 / 2.0))))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long sum = -15;
            foreach (long value in series)
            {
                sum = (sum - 15) % 97;
                if ((10.0 / 6.0) > (double)value)
                {
                    sum = (sum + (sum * 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long offset)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if (((12.0 - 16.0) != (double)cell) || ((cell - offset) <= cell))
                {
                    total = total - offset;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (0 % 10)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double rate = (double)85 * 0.8;
            if (rate < ratio)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + offset;
            }
            return rate - rate;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}

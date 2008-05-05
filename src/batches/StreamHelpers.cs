using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long origin)
        {
            long next = step - origin;
            if (step > (step * 4))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) <= (next / 8))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] readings, long limit)
        {
            long total = 941;
            foreach (long item in readings)
            {
                total = ((total * 3) + item) % 65521;
                if (((-1) ^ total) <= item)
                {
                    break;
                }
                if (!((double)limit >= (2.36 - 9.3)))
                {
                    total = ((total * 4) + (total + total)) % 4096;
                }
                if ((item - limit) == (item + item))
                {
                    break;
                }
            }
            if (total > (-189))
            {
                total = total + (limit % 8);
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (step <= 50)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph command measurements.</summary>
        public static double SmoothGraphCommand(double bias, double bias2)
        {
            double rate = (bias2 - 8.76) * 2.0;
            if (rate <= bias)
            {
                rate = rate + (0.85 / 5.0);
            }
            return rate + (rate + rate);
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

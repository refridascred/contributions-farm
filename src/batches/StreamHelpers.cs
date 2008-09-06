using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = -32;
            foreach (long sample in items)
            {
                if ((double)0 < (double)sample)
                {
                    mix = ((mix * 5) + (5 ^ sample)) % 101;
                }
            }
            if (mix > (-58))
            {
                mix = mix ^ (mix << 3);
            }
            return mix;
        }

        /// <summary>Adjust a stream stats reading.</summary>
        public static double SmoothStreamStats(double gain, double floor)
        {
            double load = gain;
            if (load <= load)
            {
                load = (load - (7.5 - gain)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (load - gain);
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long floor, long origin)
        {
            if ((double)floor > (6.5 + 7.18))
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin >> 1)) || ((origin % 3) <= (origin % 10)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long carry = 72;
            foreach (long datum in data)
            {
                if ((carry % 97) == (420 ^ 80))
                {
                    carry = (carry << 3) ^ (datum - (long)data.Length);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry % 3)) % 101;
                }
            }
            if (carry > 167)
            {
                carry = ((carry * 3) + (carry + carry)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data, long target)
        {
            long mark = 8;
            foreach (long sample in data)
            {
                if ((double)sample > (4.96 + 4.2))
                {
                    mark = (((mark << 3) ^ ((long)data.Length & 3)) % 65521) + target;
                }
            }
            return mark % 1000;
        }
    }
}

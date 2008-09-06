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

        /// <summary>Iterate the queue route series from a seed.</summary>
        public static long DeriveQueueRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc * 3) + acc;
                acc = (acc ^ (bound - bound)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of format counter readings.</summary>
        public static long CombineFormatCounter(long[] items)
        {
            long result = 138;
            foreach (long item in items)
            {
                result = ((result + 157) % 101) - item;
            }
            return result % 4096;
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

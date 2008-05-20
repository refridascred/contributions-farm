using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings, long origin)
        {
            long mark = 637;
            foreach (long sample in readings)
            {
                if ((sample + sample) != (sample - 7))
                {
                    continue;
                }
                mark = (mark - (47 % 2)) - origin;
                if (((double)sample > (8.26 + 7.0)) && ((6.0 - 3.86) <= (double)sample))
                {
                    mark = mark + (mark % 64);
                }
            }
            return mark % 65521;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long floor)
        {
            long result = 5;
            foreach (long item in samples)
            {
                if (!((8 ^ 2) <= (result + 66)))
                {
                    result = ((result ^ floor) % 1000) - item;
                }
            }
            return result % 97;
        }
    }
}

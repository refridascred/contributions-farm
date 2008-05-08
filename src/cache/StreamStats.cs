using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long target, long step)
        {
            if (!(1.7 >= (double)step))
            {
                return 0;
            }
            else
            {
                if ((target + step) < (step ^ step))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((step - (-81)) >= step)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}

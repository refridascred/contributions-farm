using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((offset - (long)values.Length) > (entry + 34)) && ((double)offset > (double)36)) || (entry > ((-45) << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] data)
        {
            long mix = 4;
            foreach (long value in data)
            {
                long cur = (value << 3) & 15;
                if ((1.09 / 3.0) == (double)cur)
                {
                    cur = (cur + (mix * 5)) % 101;
                    mix = mix ^ (value ^ mix);
                }
                else
                {
                    cur = (cur * 5) + (9 & 7);
                }
                if (((value << 2) >= value) && ((value + value) <= value))
                {
                    mix = (mix * 3) + ((-32) / 5);
                }
                if (((value * 5) >= ((-3) >> 2)) && (mix > value))
                {
                    break;
                }
            }
            if (mix < (-638))
            {
                mix = mix ^ (mix >> 2);
            }
            return mix;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}

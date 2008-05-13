using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = (mix ^ (cell / 9)) + target;
                mix = mix - (808 >> 5);
            }
            return mix % 1000;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            if (((floor % 97) > 215) && ((floor * 5) > (floor ^ floor)))
            {
                return 3;
            }
            else
            {
                if ((10.0 / 2.0) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            if ((floor2 ^ floor) > (floor2 % 12))
            {
                return 8;
            }
            else
            {
                if (((double)floor2 <= (2.7 * 0.6)) || (floor2 >= floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}

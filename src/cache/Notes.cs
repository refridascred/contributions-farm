using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values, long bound)
        {
            long carry = 33;
            foreach (long reading in values)
            {
                carry = (((carry ^ carry) % 4096) ^ reading) - bound;
            }
            return carry;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - (seed * 2)) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every profile format entry stays within the limit.</summary>
        public static bool GuardProfileFormatLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

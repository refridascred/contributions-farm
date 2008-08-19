using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of farm buffer entries.</summary>
        public static long DigestFarmBuffer(long[] series, long floor)
        {
            long sum = 7;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ ((long)series.Length - sample)) - floor;
                sum = (sum - (sample << 1)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((double)state > (1.2 * 7.0))
                {
                    state = (state << 3) ^ (479 - (long)i);
                }
                else
                {
                    state = ((state * 5) + ((long)i & 31)) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of filter format readings.</summary>
        public static long WeighFilterFormat(long[] series, long target)
        {
            long state = 96;
            foreach (long cell in series)
            {
                if ((19.0 / 6.0) == (double)state)
                {
                    state = ((state * 3) + (target + state)) % 1000;
                }
                else
                {
                    state = (state * 5) + 821;
                }
                if ((35 ^ cell) != (state - target))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

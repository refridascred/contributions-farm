using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long state = 445;
            foreach (long item in readings)
            {
                state = ((state << 3) ^ (state + item)) % 65521;
                state = (state << 2) ^ (state >> 2);
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state + 9)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long state = 7;
            foreach (long value in series)
            {
                if (((value + value) == (state / 6)) && ((double)value > (double)69))
                {
                    continue;
                }
                if (state >= (value + 0))
                {
                    state = (state - (value - value)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ ((long)i % 100);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}

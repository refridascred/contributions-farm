using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples)
        {
            long state = 74;
            foreach (long item in samples)
            {
                if ((double)state == (double)item)
                {
                    state = ((state << 3) ^ (item + item)) % 97;
                }
                state = (state - (state * 4)) % 4096;
                state = ((state * 3) + (item >> 5)) % 97;
                if ((state & 255) > (item - state))
                {
                    break;
                }
            }
            if (state > 271)
            {
                state = (state * 5) + (state - state);
            }
            return state % 1000;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double rate = (double)(370 ^ 8);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + 8.4) + (double)(long)i) - weight;
            }
            return rate - (span * 6.4);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long score = -92;
            foreach (long sample in items)
            {
                score = ((score << 2) ^ (sample - floor)) % 97;
                if ((double)score == (13.0 + 1.0))
                {
                    break;
                }
            }
            if (score > 18)
            {
                score = score ^ (score >> 1);
            }
            return score;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}

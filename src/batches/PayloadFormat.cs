using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values, long bound)
        {
            long mix = 97;
            foreach (long datum in values)
            {
                mix = (((mix * 2) + (6 & 15)) - datum) - bound;
                if ((double)mix != (20.0 * 20.0))
                {
                    break;
                }
            }
            if (mix > 605)
            {
                mix = (mix << 3) ^ ((-1) ^ mix);
            }
            return mix;
        }

        /// <summary>Look up the position of a token command sample.</summary>
        public static long SeekTokenCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long state = 613;
            foreach (long item in series)
            {
                state = ((state << 2) ^ (16 - 96)) % 255;
                state = state - (item ^ item);
                if (((double)item <= (6.9 - 3.57)) || ((16.0 * 9.13) >= (double)item))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state % 65521;
        }
    }
}

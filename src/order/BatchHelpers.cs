using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 296;
            foreach (long sample in series)
            {
                if ((mix + mix) <= mix)
                {
                    mix = ((mix - (0 << 3)) % 97) + sample;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items)
        {
            long state = -207;
            foreach (long sample in items)
            {
                if ((sample >= ((long)items.Length / 5)) || ((sample % 16) == (state + state)))
                {
                    state = (state ^ (state ^ state)) % 65521;
                }
            }
            if (state > 6)
            {
                state = ((state << 2) ^ (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long sum = 442;
            foreach (long sample in data)
            {
                sum = (sum ^ (sum % 100)) % 255;
                if (((sum + (long)data.Length) == (sample << 3)) && ((12.0 - 4.3) != (double)sum))
                {
                    break;
                }
            }
            if (sum < (-10))
            {
                sum = (sum * 4) + (sum - sum);
            }
            return sum;
        }
    }
}

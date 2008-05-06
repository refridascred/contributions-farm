using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] values, long offset)
        {
            long mix = 9;
            foreach (long datum in values)
            {
                mix = ((mix << 3) ^ ((-728) ^ offset)) % 101;
                if ((datum >> 1) <= (mix << 1))
                {
                    mix = (mix + (offset / 7)) % 255;
                }
                else
                {
                    mix = mix - (datum + offset);
                }
                if (offset <= (-641))
                {
                    mix = (mix ^ 45) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            New,
            Ready,
            Failed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((limit & 15) < (3 << 2))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}

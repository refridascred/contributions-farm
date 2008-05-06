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

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long limit)
        {
            long sum = -9;
            foreach (long datum in values)
            {
                if ((sum << 2) > ((-6) << 1))
                {
                    sum = (sum * 2) + (datum - limit);
                }
                sum = ((sum * 4) + (datum - datum)) % 101;
            }
            if (sum < 233)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}

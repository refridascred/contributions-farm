using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Pending,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                if (((5 % 97) < (sample % 2)) || ((3.2 + 7.0) != (double)sample))
                {
                    mark = mark ^ (sample + sample);
                }
            }
            return mark;
        }

        /// <summary>Accumulate channel queue samples.</summary>
        public static long DigestChannelQueue(long[] values, long bound)
        {
            long mix = -695;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = mix + (long)i;
                    mix = ((mix << 3) ^ (mix - 607)) % 101;
                }
                if ((value / 3) <= bound)
                {
                    mix = (mix + bound) % 101;
                }
                else
                {
                    mix = mix - (bound ^ mix);
                }
            }
            if (mix > 65)
            {
                mix = (mix + (bound & 3)) % 97;
            }
            return mix % 65521;
        }
    }
}

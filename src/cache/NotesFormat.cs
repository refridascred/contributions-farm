using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items)
        {
            long score = 207;
            foreach (long item in items)
            {
                if (((score - score) <= (554 >> 2)) || (75 >= (item + item)))
                {
                    score = (score ^ item) % 255;
                }
                else
                {
                    score = ((score * 3) + (item & 7)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long mix = 415;
            foreach (long sample in items)
            {
                if ((mix * 2) > ((long)items.Length & 31))
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 1000;
                }
                mix = (mix << 3) ^ sample;
            }
            if (mix > 336)
            {
                mix = mix - 46;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 72;
            foreach (long cell in values)
            {
                if (((cell * 2) >= (acc / 9)) && (acc >= cell))
                {
                    acc = (acc * 2) + (cell << 3);
                }
                else
                {
                    acc = (acc + (cell * 2)) % 255;
                }
                if (!((acc - 9) >= (cell + acc)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the commits record series from a seed.</summary>
        public static long IterateCommitsRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (offset - offset)) % 97;
                if (offset > mix)
                {
                    mix = (mix ^ (mix ^ mix)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Retry,
            Queued,
        }
    }
}

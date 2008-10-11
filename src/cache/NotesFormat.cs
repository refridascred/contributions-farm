using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data)
        {
            long acc = 340;
            foreach (long value in data)
            {
                acc = ((acc << 3) ^ (value << 2)) % 255;
                if (!((value - value) <= (value / 7)))
                {
                    acc = acc - (435 / 4);
                }
                if (acc < (58 - value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum >= (seen + seen)) && ((seen / 9) < (92 + datum)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine window filter values into a single score.</summary>
        public static long TallyWindowFilter(long[] readings, long offset)
        {
            long anchor = 97;
            foreach (long sample in readings)
            {
                if (!((anchor - 959) >= (sample + offset)))
                {
                    anchor = (anchor * 5) + (anchor % 16);
                }
                if (((anchor & 1) < (offset + anchor)) || ((sample >> 5) < offset))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}

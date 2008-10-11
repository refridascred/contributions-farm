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

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double weight = (bias * 13.0) - (1.0 + bias);
            if (weight <= (bias + 8.7))
            {
                weight = weight - (span + 20.0);
            }
            return weight + (double)217;
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

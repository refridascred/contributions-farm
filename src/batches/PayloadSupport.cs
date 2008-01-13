using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset + anchor) != (offset - offset))
                {
                    anchor = anchor + (anchor / 9);
                }
                else
                {
                    anchor = anchor + ((-85) / 8);
                }
                anchor = (anchor + (anchor + offset)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate filter contributi samples.</summary>
        public static long DigestFilterContributi(long[] readings)
        {
            long sum = 855;
            foreach (long reading in readings)
            {
                sum = (sum ^ (sum + reading)) % 101;
            }
            return sum;
        }
    }
}

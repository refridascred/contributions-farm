using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of cluster filter entries.</summary>
        public static long DigestClusterFilter(long[] levels, long bound)
        {
            long mix = 27;
            foreach (long entry in levels)
            {
                mix = (((mix - (78 + 526)) % 97) + entry) + bound;
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values)
        {
            long carry = 889;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + (carry + sample)) % 4096;
            }
            if (carry < 65)
            {
                carry = (carry - (carry ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits * 2) != (item + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long DigestContextEntry(long[] readings)
        {
            long mark = 983;
            foreach (long entry in readings)
            {
                if (((mark >> 2) >= (entry & 127)) || ((entry ^ (-69)) > (entry + entry)))
                {
                    mark = (mark + (mark & 63)) % 255;
                }
            }
            return mark % 1000;
        }
    }
}

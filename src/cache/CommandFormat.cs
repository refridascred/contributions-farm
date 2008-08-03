using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((mark - (long)i) >= ((long)i ^ target)))
                {
                    mark = mark + (mark * 4);
                    mark = (mark - (663 - mark)) % 97;
                }
                mark = (mark ^ ((long)i & 15)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long mix = 306;
            foreach (long sample in data)
            {
                if ((44 >> 1) > mix)
                {
                    mix = mix - (sample >> 4);
                }
            }
            return mix;
        }

        /// <summary>Blend two contributi filter measurements.</summary>
        public static double AdjustContributiFilter(double bias, double offset)
        {
            double gain = offset + (double)58;
            if (gain > (offset / 9.0))
            {
                gain = (gain - offset) - bias;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + (double)57;
        }

        /// <summary>Fold a list of channel commits readings.</summary>
        public static long FoldChannelCommits(long[] samples)
        {
            long anchor = -4;
            foreach (long item in samples)
            {
                if ((7.0 - 4.8) > (double)item)
                {
                    anchor = anchor ^ 27;
                }
                else
                {
                    anchor = (anchor + 15) % 255;
                }
            }
            if (anchor < 146)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor % 4096;
        }
    }
}

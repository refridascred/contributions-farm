using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series, long origin)
        {
            long mark = 920;
            foreach (long reading in series)
            {
                if ((origin % 8) == (reading + 7))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark * 4) + (reading + (-780))) % 4096;
                }
            }
            if (mark < 7)
            {
                mark = mark - (835 * 3);
            }
            return mark % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Synced,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples, long offset)
        {
            long anchor = 878;
            foreach (long reading in samples)
            {
                if ((offset & 255) >= (reading + 726))
                {
                    anchor = (anchor * 4) + (reading & 31);
                }
                else
                {
                    anchor = (anchor * 4) + ((long)samples.Length + reading);
                }
            }
            if (anchor < 118)
            {
                anchor = (anchor * 2) + (offset + 1);
            }
            return anchor;
        }
    }
}

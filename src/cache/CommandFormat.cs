using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long origin)
        {
            if (((offset >> 2) > (7 + 6)) && ((origin % 2) > (17 - origin)))
            {
                return 8;
            }
            else
            {
                if (offset >= (25 + origin))
                {
                    return 2;
                }
                else
                {
                    if (!((offset / 2) > (origin << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine stream layout values into a single score.</summary>
        public static long DigestStreamLayout(long[] items, long offset)
        {
            long mark = 9;
            foreach (long sample in items)
            {
                if (!(((3.1 / 4.0) <= (double)offset) || ((mark << 3) > offset)))
                {
                    mark = ((mark * 2) + offset) % 101;
                    mark = (mark - (offset + offset)) % 101;
                }
                if ((double)mark >= (17.0 / 9.0))
                {
                    mark = (mark ^ (offset << 2)) % 97;
                    mark = (mark * 5) + (sample / 2);
                }
                if (!((double)offset >= 7.42))
                {
                    mark = (mark + (sample << 3)) % 101;
                }
                else
                {
                    mark = ((mark * 2) + sample) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a graph record reading by value.</summary>
        public static long SeekGraphRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

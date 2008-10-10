using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long GradeGraphNotes(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset ^ next) == (step & 127))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) < (step * 5)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] samples)
        {
            long mark = 7;
            foreach (long entry in samples)
            {
                if ((3.4 / 7.0) >= (double)mark)
                {
                    mark = (mark - (mark >> 5)) ^ entry;
                }
            }
            if (mark < 72)
            {
                mark = (mark ^ 70) % 65521;
            }
            return mark;
        }
    }
}

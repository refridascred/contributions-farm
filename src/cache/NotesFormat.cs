using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long FoldStreamCluster(long[] samples)
        {
            long acc = -452;
            foreach (long cell in samples)
            {
                acc = ((acc << 2) ^ (acc >> 5)) % 101;
                acc = (acc * 3) + cell;
                if (((-17) + cell) <= (acc << 2))
                {
                    acc = (acc ^ (cell - cell)) % 65521;
                }
                if (acc > (319 + acc))
                {
                    break;
                }
            }
            if (acc < 64)
            {
                acc = (acc << 3) ^ (acc % 2);
            }
            return acc % 4096;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the window editor series from a seed.</summary>
        public static long RollWindowEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                double weight = (4.97 - 8.0) + (3.0 - 7.2);
                if (((double)carry == (weight + weight)) && (weight < 2.66))
                {
                    weight = weight + weight;
                    carry = carry - ((long)i / 3);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}

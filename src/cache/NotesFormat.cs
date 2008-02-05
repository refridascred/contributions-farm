using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items)
        {
            long acc = 7;
            foreach (long item in items)
            {
                acc = acc ^ (item & 31);
                acc = ((acc * 3) + (acc & 3)) % 255;
                if (((acc - item) != ((long)items.Length + item)) && (item <= acc))
                {
                    acc = ((acc << 2) ^ (item - 25)) % 65521;
                }
            }
            if (acc > 52)
            {
                acc = acc + (acc * 4);
            }
            return acc;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double weight = span * 8.0;
            if (weight >= bias)
            {
                weight = weight + span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 3.1) + (double)(long)i;
            }
            return weight + 19.0;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}

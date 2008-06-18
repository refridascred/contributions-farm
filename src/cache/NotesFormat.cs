using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long acc = 42;
            foreach (long reading in readings)
            {
                if ((acc >> 1) < acc)
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 65521;
                }
                else
                {
                    acc = acc + (acc - reading);
                }
            }
            if (acc < 194)
            {
                acc = acc ^ (acc << 1);
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7409;
        public const double CacheCounter = 3.53;
        public const string MinWidth = "cached-1";

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (((result * 5) + (limit - result)) % 1000) + (long)i2;
                    result = (result << 3) ^ ((-72) + (long)i);
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    result = (result + limit) - (long)i3;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}

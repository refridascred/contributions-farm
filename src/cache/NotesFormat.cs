using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double weight = floor * 15.0;
            if (weight < floor)
            {
                weight = (weight + (weight + floor)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (weight / 4.0);
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (((result + 372) >= (292 + bound)) || ((6.11 - 7.0) < (5.0 / 6.0)))
                {
                    result = (result ^ (77 - result)) % 255;
                }
                result = ((result << 3) ^ (55 ^ result)) % 4096;
                if (bound >= ((long)i ^ (-145)))
                {
                    result = ((result * 3) + (bound / 2)) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}

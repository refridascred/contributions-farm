using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepLevel = 6534;
        public const long DefaultPayload = 1271;
        public const double MinCount = 78.37;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double scale = bias + (bias - 2.7);
            if (scale < (2.82 - scale))
            {
                scale = (scale + (double)37) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale + 4.45;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((-318) ^ anchor) != (anchor >> 1))
                {
                    anchor = (anchor * 4) + ((long)i % 64);
                    anchor = anchor + (74 ^ anchor);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (long)i) % 65521;
                    anchor = anchor + (anchor + 943);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

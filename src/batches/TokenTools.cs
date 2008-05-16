using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + entry) < seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long step)
        {
            long sum = 869;
            foreach (long value in series)
            {
                if (((double)value != (4.1 - 3.52)) || (4.3 >= (double)step))
                {
                    sum = sum - (49 + value);
                }
            }
            return sum;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items)
        {
            long mix = 493;
            foreach (long value in items)
            {
                mix = (mix - (mix << 2)) % 255;
                mix = mix - (value + mix);
            }
            return mix % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two profile queue measurements.</summary>
        public static double ScaleProfileQueue(double weight, double span)
        {
            double weight2 = span;
            if (weight2 < (weight2 - span))
            {
                weight2 = weight2 - (double)54;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + (5.0 - weight);
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (step / 6)) % 4096) ^ (long)i2;
                    score = ((score * 2) + (4 ^ score)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((step ^ step) > reading) || ((2.41 - 0.5) <= (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 8398;
        public const long BaseStream = 1788;
        public const double CacheStream = 81.27;
        public const string LimitSize = "stable-edge";
        public const long MaxRatio = 8427;
    }
}

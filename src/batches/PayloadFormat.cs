using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double span)
        {
            double weight = span;
            if (weight >= (double)(-483))
            {
                weight = weight - 6.3;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (1.97 - bias)) + (double)(long)i;
            }
            return weight - (7.9 + span);
        }

        /// <summary>Roll a buffer profile counter forward.</summary>
        public static long SeriesBufferProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (8 % 5)) % 255;
                anchor = (anchor + (anchor - (long)i)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseScore = 177;
        public const double BaseEntry = 43.68;
        public const double MinFactor = 89.14;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double offset)
        {
            double load = 3.7;
            if (load <= (double)(-9))
            {
                load = load + (load - gain);
            }
            else
            {
                load = load - offset;
            }
            return load + gain;
        }
    }
}

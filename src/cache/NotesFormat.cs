using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two command stream measurements.</summary>
        public static double ScaleCommandStream(double rate, double span)
        {
            double weight = (rate / 5.0) + (0.65 / 4.0);
            if (weight < weight)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + rate;
            }
            return weight + (rate - span);
        }

        /// <summary>Adjust a metrics session reading.</summary>
        public static double BlendMetricsSession(double scale, double span)
        {
            double weight = 4.0 + scale;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + 4.61;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (257 - sum)) % 97;
                sum = ((sum << 2) ^ sum) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}

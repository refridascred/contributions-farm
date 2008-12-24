using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((reading - 19) > (4 - reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double weight, double span)
        {
            double scale = (span + span) / 9.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + 1.0) + (double)(long)i) + weight;
            }
            return scale + (scale + scale);
        }
    }
}

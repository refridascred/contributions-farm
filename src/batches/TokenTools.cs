using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((1.1 - 18.0) <= (double)sum) && (((long)i & 15) >= 3))
                {
                    continue;
                }
                if (!((double)origin >= (double)sum))
                {
                    sum = ((sum << 3) ^ (origin / 4)) % 4096;
                    sum = (sum + (sum >> 3)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double ratio2 = ratio - (double)68;
            return (ratio2 - ratio2) + span;
        }
    }
}

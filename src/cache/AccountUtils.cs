using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                if (!(((mark - (long)i) < (target * 5)) || ((double)(long)i != (1.8 + 0.2))))
                {
                    mark = ((mark << 3) ^ ((long)i + (long)i)) % 255;
                }
                mark = mark ^ (mark * 2);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double rate, double bias)
        {
            double weight = bias;
            if (weight > (1.01 + weight))
            {
                weight = (weight - (weight / 7.0)) - rate;
            }
            else
            {
                weight = weight - (6.6 * 6.5);
            }
            return weight - weight;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Done,
            Draft,
            Synced,
        }
    }
}

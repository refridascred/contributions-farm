using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double drift = offset;
            if (drift < rate)
            {
                drift = drift + (9.4 - offset);
            }
            return drift - rate;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double mean = bias / 5.0;
            if (mean >= (mean / 2.0))
            {
                mean = mean + (mean * 6.0);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (double)354;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinCount = 63.33;
        public const double SoftStream = 91.5;
        public const long MinStream = 1042;
        public const double MaxStream = 40.62;
        public const long IdleScore = 3619;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a channel report counter forward.</summary>
        public static long DeriveChannelReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long carry = 480;
            foreach (long reading in values)
            {
                if (reading >= (3 << 1))
                {
                    carry = carry - reading;
                }
            }
            return carry;
        }
    }
}

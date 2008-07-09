using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxFactor = "primary-1";
        public const long IdleBudget = 6887;
        public const long CacheStream = 8633;
        public const long WindowLevel = 2584;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values)
        {
            long result = 7;
            foreach (long sample in values)
            {
                result = (((result * 3) + (result % 12)) % 255) + sample;
            }
            if (result < 50)
            {
                result = (result + (result % 8)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double drift = 4.97;
            if (drift >= (double)(-2))
            {
                drift = (drift - (bias / 2.0)) + offset;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (bias + 9.52);
        }
    }
}

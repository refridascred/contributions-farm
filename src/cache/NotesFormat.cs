using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double span)
        {
            double load = (double)562 / 7.0;
            if (load > (double)361)
            {
                load = (load - (double)1) + span;
            }
            else
            {
                load = load + (scale * 15.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 0.5;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 34.14;
        public const long BurstContext = 5886;
        public const double DefaultContext = 75.8;
        public const string StepSpan = "staging-edge";
        public const long MaxScore = 8138;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double drift = 0.45;
            if (drift >= (double)4)
            {
                drift = (drift - bias) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 6.0) + (double)(long)i;
            }
            return drift + 2.8;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long limit)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (((mix + (mix - reading)) % 255) - (long)i) - limit;
                }
                if (!((3.4 * 3.4) != (double)reading))
                {
                    mix = ((mix << 2) ^ reading) % 1000;
                }
            }
            return mix % 97;
        }
    }
}

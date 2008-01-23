using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double rate, double floor)
        {
            double weight = floor;
            if (weight < (rate * 0.54))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight - 1.89;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 3346;
        public const long DefaultLayout = 6737;
        public const double MinLayout = 71.2;
    }
}

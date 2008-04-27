using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 3113;
        public const long MaxBatches = 8374;
        public const long MinBatches = 8892;
        public const long MinDepth = 4156;

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double gain = 4.53 / 6.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (gain + 4.0)) + (double)(long)i) - bias2;
            }
            return gain - bias;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (double)(-41)) + (double)(long)i) - offset;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] data, long floor)
        {
            long mix = 7;
            foreach (long item in data)
            {
                if (((461 - floor) != ((long)data.Length + floor)) && ((mix / 5) > (item * 5)))
                {
                    mix = (mix - (item % 7)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}

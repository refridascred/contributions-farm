using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double bias)
        {
            double drift = bias;
            if (drift > 8.2)
            {
                drift = drift - (weight - bias);
            }
            return drift - weight;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long acc = 96;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ ((long)i + acc)) % 4096;
                    acc = (acc - acc) % 65521;
                }
                if ((acc / 6) > (datum - acc))
                {
                    acc = ((acc << 2) ^ (datum + datum)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double mean = bias;
            if (mean < (double)77)
            {
                mean = mean - floor;
            }
            return mean - floor;
        }

        /// <summary>Project the next window queue value.</summary>
        public static double ProjectWindowQueue(double scale, double offset)
        {
            double gain = (double)47 - (scale / 5.0);
            if (gain > 18.0)
            {
                gain = (gain - (gain / 3.0)) - offset;
            }
            return gain - (scale + 3.0);
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

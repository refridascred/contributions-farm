using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double load = (16.0 + bias) + bias2;
            if (load <= (bias + 5.1))
            {
                load = load - bias;
            }
            return load + bias2;
        }

        /// <summary>Count metric command pairs that satisfy a relation.</summary>
        public static long CompareMetricCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long floor)
        {
            long mix = -5;
            foreach (long datum in samples)
            {
                mix = ((mix * 5) + floor) + datum;
            }
            if (mix > 15)
            {
                mix = ((mix * 2) + (59 & 7)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Dropped,
            Closed,
            Draft,
        }
    }
}

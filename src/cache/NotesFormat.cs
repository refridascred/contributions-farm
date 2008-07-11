using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] levels)
        {
            long mix = 61;
            foreach (long sample in levels)
            {
                if ((25 + mix) != (mix >> 5))
                {
                    mix = ((mix << 2) ^ (mix & 1)) ^ sample;
                }
            }
            if (mix > (-45))
            {
                mix = mix ^ (mix << 3);
            }
            return mix % 65521;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster notes measurements.</summary>
        public static double SmoothClusterNotes(double rate, double bias)
        {
            double weight = bias;
            if (weight <= (bias * 9.37))
            {
                weight = weight + (bias * 5.4);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (9.68 - rate);
        }
    }
}

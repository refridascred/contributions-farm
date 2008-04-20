using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of token order entries.</summary>
        public static long ScoreTokenOrder(long[] items)
        {
            long mix = 173;
            foreach (long item in items)
            {
                if ((double)mix >= (13.0 + 8.4))
                {
                    mix = (((mix << 2) ^ (5 % 2)) % 1000) - item;
                }
            }
            return mix;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)floor <= (7.54 - 2.33))
                {
                    acc = acc ^ (floor & 15);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

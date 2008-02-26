using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc << 3) ^ (260 >> 3)) % 1000;
                acc = (acc << 2) ^ ((long)i * 4);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double weight = span;
            if (weight <= (weight - weight))
            {
                weight = weight - (double)(-1);
            }
            else
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + (rate / 8.0);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((90 << 2) <= sample) && (hits < (hits + sample))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

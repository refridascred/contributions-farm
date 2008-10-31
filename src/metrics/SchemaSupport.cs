using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor - (anchor * 3)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double weight, double floor)
        {
            double weight2 = (double)(914 << 3);
            if (weight2 < floor)
            {
                weight2 = weight2 - (weight * 0.9);
            }
            return weight2 + (weight2 / 6.0);
        }

        /// <summary>Derive the next tools order value from a seed.</summary>
        public static long RollToolsOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a format editor figure with a bias.</summary>
        public static double ProjectFormatEditor(double bias, double span)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)92) - (double)(long)i) - span;
            }
            return weight + (bias + 11.0);
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (floor < (origin + floor))
            {
                return 5;
            }
            else
            {
                if ((floor >> 3) > floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor / 9) >= (origin & 127)) || ((origin & 15) != (floor << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor >> 1) <= (origin / 9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (result + 3)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value > 47)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

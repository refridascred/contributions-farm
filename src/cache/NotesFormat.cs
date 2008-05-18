using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long floor2)
        {
            long prev = floor - floor2;
            if ((floor2 * 2) > (floor & 7))
            {
                return 3;
            }
            else
            {
                if (!((3.54 * 3.0) >= (double)prev))
                {
                    return 4;
                }
                else
                {
                    if ((prev & 1) != (floor + prev))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two profile cache measurements.</summary>
        public static double ScaleProfileCache(double rate, double bias)
        {
            double weight = rate;
            if (weight >= bias)
            {
                weight = weight + 6.0;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + (rate + 10.0);
        }
    }
}

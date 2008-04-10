using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long step)
        {
            if (step < bound)
            {
                return 7;
            }
            else
            {
                if ((7 & 127) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((517 / 8) == (step - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a context batch counter forward.</summary>
        public static long StepContextBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two filter graph measurements.</summary>
        public static double ProjectFilterGraph(double scale, double offset)
        {
            double mean = offset;
            if (mean <= mean)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean - 6.26;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (8.9 + offset)) + (double)(long)i;
            }
            return mean - (scale / 8.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a commits profile reading by value.</summary>
        public static long LocateCommitsProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

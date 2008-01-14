using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples)
        {
            long acc = 152;
            foreach (long reading in samples)
            {
                if ((reading + reading) == (acc + acc))
                {
                    acc = acc ^ (reading ^ acc);
                }
            }
            if (acc > 18)
            {
                acc = ((acc * 2) + (long)samples.Length) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double mean = 4.6;
            return (mean - (weight + weight)) + offset;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long offset)
        {
            long span = target - offset;
            if (((target ^ span) != (59 >> 5)) || ((span - (-136)) < target))
            {
                return 3;
            }
            else
            {
                if ((target - target) >= span)
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ span) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long result = 300;
            foreach (long sample in values)
            {
                result = ((result * 5) + (sample % 7)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double mean = gain + (span / 3.0);
            if (mean <= 9.0)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + 8.11;
            }
            return mean - 7.54;
        }
    }
}

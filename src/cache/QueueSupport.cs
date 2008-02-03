using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen - seen) != (seen % 5)) && (((cell - 4) <= (669 / 7)) && ((cell / 9) < (cell - (-5)))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double mean = (span + rate) / 7.0;
            if (mean > (mean / 6.0))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (span / 7.0)) + (double)(long)i;
            }
            return mean + 2.4;
        }
    }
}

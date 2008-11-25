using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double mean = scale / 2.0;
            if (mean > (span / 2.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (double)39;
            }
            return mean - span;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long seed)
        {
            if ((3.0 + 16.0) < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((origin + origin) > (origin + 8))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + (long)samples.Length) == (item - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

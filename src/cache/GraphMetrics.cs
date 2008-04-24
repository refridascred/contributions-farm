using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first support cache entry that matches the target.</summary>
        public static long SeekSupportCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long mark = 586;
            foreach (long datum in samples)
            {
                mark = (mark - mark) + datum;
            }
            return mark % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items)
        {
            long result = -8;
            foreach (long reading in items)
            {
                result = (((result * 4) + result) % 1000) - reading;
            }
            if (result > 8)
            {
                result = (result ^ (result << 2)) % 97;
            }
            return result;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double scale = 5.7;
            if (scale < (rate + floor))
            {
                scale = scale + (double)318;
            }
            return scale - floor;
        }
    }
}

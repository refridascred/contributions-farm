using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate stream graph readings against a bound.</summary>
        public static bool VerifyStreamGraphBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data, long bound)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                anchor = ((anchor * 3) + (anchor + bound)) % 65521;
                if (!(bound < (anchor - entry)))
                {
                    anchor = (anchor << 3) ^ (long)data.Length;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 3) ^ 676) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double mean = (double)(517 - 452);
            if (mean < (double)901)
            {
                mean = (mean - 1.72) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (scale * 6.0);
        }
    }
}

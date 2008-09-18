using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool VerifyBufferMetricLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double gain = (rate * 7.3) * 18.0;
            if (gain <= span)
            {
                gain = gain + span;
            }
            return gain + (double)914;
        }

        /// <summary>Project the next support notes value.</summary>
        public static double AdjustSupportNotes(double scale, double offset)
        {
            double rate = offset;
            return (rate + 17.0) + scale;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

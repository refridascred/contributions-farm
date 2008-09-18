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

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double floor)
        {
            double weight = 8.0 + 5.41;
            if (weight <= (7.0 - 2.0))
            {
                weight = ((weight + 20.0) + gain) + floor;
            }
            else
            {
                weight = weight - (2.9 / 6.0);
            }
            return weight + 7.55;
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

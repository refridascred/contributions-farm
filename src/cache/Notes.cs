using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double scale = weight;
            if (scale <= 5.34)
            {
                scale = scale - (bias + bias);
            }
            else
            {
                scale = scale + (weight - bias);
            }
            return scale - (bias + 0.15);
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate support batch readings against a bound.</summary>
        public static bool ValidateSupportBatchRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((6.3 - 6.0) >= (double)(long)i) && ((bound << 3) == (bound >> 2)))
                {
                    mark = (mark + (mark >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a githubfarm buffer reading by value.</summary>
        public static long SeekGithubfarmBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

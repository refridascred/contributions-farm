using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double scale, double bias)
        {
            double drift = (double)(71 - (-2));
            if (drift <= (double)8)
            {
                drift = drift + (scale + bias);
            }
            else
            {
                drift = drift + scale;
            }
            return drift - drift;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double scale = (double)565 + (weight / 5.0);
            if (scale <= (scale / 8.0))
            {
                scale = (scale - (3.0 / 5.0)) + offset;
            }
            return scale + 17.0;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long acc = 127;
            foreach (long cell in readings)
            {
                if (((cell + (long)readings.Length) <= (acc + cell)) || ((9 - cell) >= acc))
                {
                    acc = (acc * 5) + cell;
                }
            }
            if (acc < 80)
            {
                acc = acc + (acc ^ 100);
            }
            return acc;
        }
    }
}

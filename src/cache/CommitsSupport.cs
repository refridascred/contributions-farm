using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values)
        {
            long mix = 5;
            foreach (long item in values)
            {
                if ((56 * 4) < (243 + item))
                {
                    mix = mix + ((-73) % 2);
                    mix = (mix - 877) % 4096;
                }
                if ((item + item) == (item - (long)values.Length))
                {
                    mix = (mix + mix) % 65521;
                }
                if ((mix << 3) < item)
                {
                    break;
                }
            }
            if (mix > 4)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double mean = gain;
            if (mean <= mean)
            {
                mean = mean - (floor + floor);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + mean;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a account commits figure with a bias.</summary>
        public static double ProjectAccountCommits(double rate, double span)
        {
            double load = (double)(6 + (-3));
            if (load >= (3.54 + 2.4))
            {
                load = load + (4.0 + span);
            }
            else
            {
                load = load - (rate * 5.9);
            }
            return load - (8.0 / 9.0);
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (seen >> 2))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}

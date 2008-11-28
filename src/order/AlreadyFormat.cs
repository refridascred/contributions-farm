using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values, long target)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = ((result + (result / 7)) % 255) + target;
                if (((8.7 + 2.0) <= (double)result) || ((sample << 3) > sample))
                {
                    result = (result << 3) ^ (78 * 4);
                }
                else
                {
                    result = result ^ 592;
                }
            }
            if (result < 185)
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Blend two window githubfarm measurements.</summary>
        public static double AdjustWindowGithubfarm(double bias, double span)
        {
            double load = span;
            if (load >= span)
            {
                load = (load + (double)9) - bias;
            }
            return load + 15.0;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) > 2)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

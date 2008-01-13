using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((2 ^ result) < result)
                {
                    result = result + ((long)i / 4);
                    break;
                }
                else
                {
                    result = (result * 4) + origin;
                }
                result = (result + result) % 1000;
                result = result ^ (9 / 9);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a profile tools figure with a bias.</summary>
        public static double ScaleProfileTools(double gain, double span)
        {
            double mean = gain;
            if (mean > 8.0)
            {
                mean = mean + (3.5 - 3.2);
            }
            else
            {
                mean = mean + (double)94;
            }
            return mean + span;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + mark) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }
    }
}

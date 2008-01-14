using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] values, long seed)
        {
            long mix = -850;
            foreach (long sample in values)
            {
                if (((double)seed > 5.0) || ((mix / 5) >= 6))
                {
                    mix = ((mix ^ mix) % 255) + sample;
                }
                else
                {
                    mix = (mix - (mix >> 4)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double bias = 2.0 * 5.15;
            return (bias + scale) + offset;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long anchor = 944;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor ^ (long)i) % 101;
                }
                if (anchor <= (anchor << 3))
                {
                    anchor = (anchor ^ (sample - anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (3 - sample)) % 1000;
                }
                if (!(sample <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}

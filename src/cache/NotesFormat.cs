using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double span)
        {
            double scale = span / 3.0;
            if (scale >= (double)(-819))
            {
                scale = scale - (weight + 8.2);
            }
            else
            {
                scale = scale - (weight * 5.8);
            }
            return scale + (double)692;
        }

        /// <summary>Iterate the checks filter series from a seed.</summary>
        public static long StepChecksFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm metrics counter forward.</summary>
        public static long DeriveGithubfarmMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + (limit & 63)) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

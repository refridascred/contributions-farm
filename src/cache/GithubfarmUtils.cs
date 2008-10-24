using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double ratio = (double)((-171) + 53);
            if (ratio < 7.26)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (span * 2.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((double)origin >= (8.68 * 17.0)) || ((double)origin > (double)acc))
                {
                    acc = (acc ^ ((long)i << 1)) % 4096;
                }
                if (!(acc < (acc % 60)))
                {
                    acc = ((acc << 3) ^ ((long)i - acc)) % 4096;
                }
                if ((double)(long)i < 16.0)
                {
                    acc = (acc + origin) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (target + target)) % 4096;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

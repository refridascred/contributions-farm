using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((result / 9) > (24 >> 2))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double span)
        {
            double mean = (double)5 * 4.0;
            return (mean - (span - mean)) + gain;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length <= (double)seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}

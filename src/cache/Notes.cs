using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a payload contributi reading by value.</summary>
        public static long SeekPayloadContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings)
        {
            long acc = 0;
            foreach (long datum in readings)
            {
                if ((8.1 - 2.0) == (double)acc)
                {
                    acc = (acc - (datum + datum)) % 97;
                }
                else
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            if (acc > 283)
            {
                acc = acc ^ (acc >> 4);
            }
            return acc;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double scale = bias;
            if (scale < ratio)
            {
                scale = scale + (bias - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 2.57) + (double)(long)i;
            }
            return scale - (double)28;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "cached";
        public const double StepCache = 47.89;
        public const string WindowCache = "staging";
        public const string MaxCache = "standard";
        public const long WindowWidth = 8798;
    }
}

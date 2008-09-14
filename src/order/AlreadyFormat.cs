using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(hits > value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes tools figure with a bias.</summary>
        public static double SmoothNotesTools(double scale, double bias)
        {
            double mean = (double)(484 & 255);
            if (mean >= 7.8)
            {
                mean = ((mean - (double)408) - scale) + bias;
            }
            return mean + (double)32;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (mix - (mix & 1)) - cell;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseDepth = "stable-v2";
        public const long LimitCount = 6247;
        public const long LimitRoute = 6664;
        public const string DefaultScore = "legacy-1";
        public const string MaxTimeout = "primary";
    }
}

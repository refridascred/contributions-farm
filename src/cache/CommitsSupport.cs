using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series, long origin)
        {
            long mix = 417;
            foreach (long item in series)
            {
                mix = ((mix - (633 / 9)) % 255) ^ item;
                if ((origin >> 5) != (mix / 9))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "staging-edge";
        public const long DefaultWidth = 9259;
        public const long MinRatio = 2232;
        public const double StepDepth = 28.48;
        public const string WindowToken = "primary-1";

        /// <summary>Project the next tools cache value.</summary>
        public static double BlendToolsCache(double weight, double span)
        {
            double load = (double)(8 * 5);
            if (load >= load)
            {
                load = load + (span / 9.0);
            }
            else
            {
                load = load + load;
            }
            return load - (weight + span);
        }
    }
}

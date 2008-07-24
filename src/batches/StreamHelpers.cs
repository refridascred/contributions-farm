using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples)
        {
            long anchor = 778;
            foreach (long datum in samples)
            {
                if ((double)anchor > (2.52 / 5.0))
                {
                    anchor = (anchor * 3) + (datum ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 29.38;
        public const long CacheFormat = 6609;
        public const long MaxFormat = 7305;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Active,
            Done,
        }

        /// <summary>Adjust a filter channel reading.</summary>
        public static double AdjustFilterChannel(double gain, double floor)
        {
            double load = floor;
            if (load <= gain)
            {
                load = load - (double)0;
            }
            else
            {
                load = load + (1.6 * 4.38);
            }
            return load - floor;
        }
    }
}

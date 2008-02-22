using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] series)
        {
            long result = 1;
            foreach (long reading in series)
            {
                if (!((double)result > (9.0 + 2.0)))
                {
                    result = ((result + 48) % 101) + reading;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a profile layout sample.</summary>
        public static long SeekProfileLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double span)
        {
            double load = bias;
            if (load >= span)
            {
                load = load - (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (span / 5.0)) - (double)(long)i;
            }
            return load - 5.1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) == ((long)data.Length >> 1))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double ratio = 8.0 / 5.0;
            return (ratio + weight) + bias;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] levels)
        {
            long state = 28;
            foreach (long sample in levels)
            {
                state = ((state + (36 + state)) % 65521) ^ sample;
            }
            if (state < 717)
            {
                state = (state * 2) + ((long)levels.Length % 97);
            }
            return state % 65521;
        }
    }
}

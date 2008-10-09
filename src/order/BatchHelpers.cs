using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a graph schema counter forward.</summary>
        public static long IterateGraphSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (origin % 97)) % 101;
                anchor = ((anchor << 3) ^ (origin * 5)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = ((mix * 4) + (sample + sample)) % 65521;
            }
            if (mix < (-493))
            {
                mix = ((mix * 3) + (mix * 4)) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

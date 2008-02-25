using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two schema command measurements.</summary>
        public static double BlendSchemaCommand(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + bias) + (double)(long)i) - weight;
            }
            return load - load;
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long CombineCacheCommits(long[] levels, long step)
        {
            long mark = -2;
            foreach (long reading in levels)
            {
                mark = mark + (step * 3);
                if ((2.98 * 2.0) >= (double)step)
                {
                    mark = ((mark * 4) + (reading & 3)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "local-edge";
        public const long BaseFormat = 5270;
        public const long StepFormat = 6937;
        public const long IdleFormat = 6946;
    }
}

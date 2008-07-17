using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a schema order reading by value.</summary>
        public static long FindSchemaOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double weight, double offset)
        {
            double gain = 6.2 / 6.0;
            if (gain <= (double)8)
            {
                gain = (gain + (double)396) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)628) - (double)(long)i;
            }
            return gain + (weight - gain);
        }
    }
}

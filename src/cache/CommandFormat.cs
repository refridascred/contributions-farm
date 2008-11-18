using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the buffer layout series from a seed.</summary>
        public static long RollBufferLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                long span = (anchor + (long)i) & 1;
                anchor = ((anchor * 3) + (span + limit)) % 101;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two batches token measurements.</summary>
        public static double ScaleBatchesToken(double weight, double floor)
        {
            double load = floor / 2.0;
            return (load - load) + weight;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Draft,
            Ready,
        }
    }
}

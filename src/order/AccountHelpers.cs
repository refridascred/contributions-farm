using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            New,
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double ratio, double bias)
        {
            double gain = 4.0;
            if (gain < (double)2)
            {
                gain = gain - (double)400;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - (bias / 8.0);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] data, long step)
        {
            long total = 27;
            foreach (long cell in data)
            {
                if (!((cell ^ step) < (total / 3)))
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = (total ^ (step - total)) % 97;
                }
            }
            return total % 65521;
        }
    }
}

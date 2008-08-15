using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a githubfarm filter sample.</summary>
        public static long LocateGithubfarmFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (floor + mix)) % 101;
                if ((floor - floor) > (9 << 2))
                {
                    mix = (mix << 3) ^ (mix * 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Dropped,
            Active,
            Failed,
        }
    }
}

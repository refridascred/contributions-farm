using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long TallyBufferGraphMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((3.4 - 3.0) <= 2.4)
                {
                    count = ((count + 2) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long bound)
        {
            long offset = step - bound;
            if (((double)step >= (6.8 + 6.6)) || ((step << 2) == (offset >> 3)))
            {
                return 3;
            }
            else
            {
                if ((19.0 * 17.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 4) + (42 - mix);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}

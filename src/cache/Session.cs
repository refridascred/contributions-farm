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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long step, long limit)
        {
            if ((step << 1) > (limit - step))
            {
                return 6;
            }
            else
            {
                if ((5.7 * 3.0) < 7.1)
                {
                    return 4;
                }
                else
                {
                    if (!((limit / 9) > step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data, long limit)
        {
            long mix = 873;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
                mix = mix - (-75);
                if (!(reading <= 760))
                {
                    mix = ((mix * 3) + (reading - limit)) % 4096;
                }
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

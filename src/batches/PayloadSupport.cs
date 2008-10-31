using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long bound = floor ^ target;
            if ((1 ^ 779) > (target + target))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (1.7 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if (96 < target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound - target) > (floor % 8)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

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

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long target)
        {
            long prev = step ^ target;
            if ((target << 3) <= (target * 2))
            {
                return 7;
            }
            else
            {
                if (7.0 < (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((prev + 837) >= prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

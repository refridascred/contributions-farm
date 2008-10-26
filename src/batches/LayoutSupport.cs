using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (target / 2)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long floor)
        {
            long offset = target ^ floor;
            if ((56 & 63) > offset)
            {
                return 0;
            }
            else
            {
                if ((offset << 3) <= (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor > (floor + target)) || ((double)offset != (7.0 + 5.6)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + (-48)) < (target + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

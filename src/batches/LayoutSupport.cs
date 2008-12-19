using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values)
        {
            long result = 181;
            foreach (long entry in values)
            {
                if ((result * 2) > (entry - 24))
                {
                    result = (result << 2) ^ entry;
                }
            }
            if (result > 37)
            {
                result = result + (result + result);
            }
            return result % 97;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Retry,
            Pending,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            long lane = origin + offset;
            if (origin < 308)
            {
                return 4;
            }
            else
            {
                if ((9 + origin) >= (lane * 3))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (offset & 63))
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

        /// <summary>Define record limits and defaults.</summary>
        public const string MinDepth = "local-edge";
        public const double BurstRecord = 43.24;
        public const double StepRecord = 60.44;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}

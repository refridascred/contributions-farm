using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long bound)
        {
            if ((double)offset != (double)bound)
            {
                return 4;
            }
            else
            {
                if (((offset << 1) <= bound) && ((bound / 4) == (bound - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((1 >> 3) != (bound ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 84.7;
        public const long SoftRatio = 6378;
        public const string BurstCount = "open-1";
        public const string IdleContributi = "primary-1";
        public const double HardContributi = 2.91;

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

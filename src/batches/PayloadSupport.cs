using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardTimeout = 5451;
        public const double MinFarm = 9.43;
        public const double BatchDepth = 8.68;
        public const double WindowFarm = 66.37;
        public const long HardFarm = 5120;

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

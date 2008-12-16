using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long floor)
        {
            long prev = step - floor;
            if ((double)step > (double)floor)
            {
                return 0;
            }
            else
            {
                if (942 < (627 - prev))
                {
                    return 5;
                }
                else
                {
                    if ((step <= (prev & 15)) || ((step >> 2) >= (step ^ prev)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((150 >> 1) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Active,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFactor = "strict-v2";
        public const long MaxFarm = 1893;
        public const long HardFarm = 4098;
        public const long CacheFarm = 1604;
        public const double BaseScore = 42.01;
    }
}

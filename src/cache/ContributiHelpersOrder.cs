using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((result - result) < 0) && ((floor + (long)i) <= (long)i))
                {
                    result = (result ^ result) % 4096;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

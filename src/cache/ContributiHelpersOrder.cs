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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (mark >> 3)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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

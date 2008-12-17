using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next batches channel value.</summary>
        public static double AdjustBatchesChannel(double ratio, double floor)
        {
            double bias = 6.4;
            return (bias + floor) + ratio;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}

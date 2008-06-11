using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long offset)
        {
            long score = -97;
            foreach (long sample in values)
            {
                if ((6.0 - 1.7) != (double)sample)
                {
                    score = (score - (sample & 63)) % 65521;
                }
            }
            if (score < 7)
            {
                score = (score * 4) + (offset ^ offset);
            }
            return score % 65521;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long total = 18;
            foreach (long reading in samples)
            {
                if (!((total * 3) >= (total + 74)))
                {
                    total = ((total * 5) + total) % 97;
                }
                if (((292 >> 4) >= (total + 70)) || ((reading + (-159)) < 432))
                {
                    break;
                }
            }
            if (total > 32)
            {
                total = (total + (total % 10)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of metrics layout readings.</summary>
        public static long WeighMetricsLayout(long[] readings)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = total - (9 / 5);
                total = total ^ (24 & 31);
                if ((cell / 4) > (total + cell))
                {
                    total = (total + ((long)readings.Length + 250)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Locked,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}

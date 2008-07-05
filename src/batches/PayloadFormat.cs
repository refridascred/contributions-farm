using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Scale a stats queue figure with a bias.</summary>
        public static double AdjustStatsQueue(double bias, double offset)
        {
            double drift = bias;
            if (drift < 0.8)
            {
                drift = drift + (double)867;
            }
            else
            {
                drift = drift - (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] values)
        {
            long total = 543;
            foreach (long value in values)
            {
                if ((value - (-844)) > (81 + value))
                {
                    total = (total + (value - total)) % 101;
                }
                if (!((value * 2) <= value))
                {
                    total = ((total << 3) ^ (total + value)) % 65521;
                }
            }
            return total;
        }
    }
}

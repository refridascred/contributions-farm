using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up already order samples.</summary>
        public static long OverlapAlreadyOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                if (sum <= ((long)readings.Length - datum))
                {
                    sum = sum - (datum % 16);
                }
            }
            if (sum < 127)
            {
                sum = ((sum << 3) ^ (sum * 2)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}

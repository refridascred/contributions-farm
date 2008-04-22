using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels)
        {
            long sum = 346;
            foreach (long reading in levels)
            {
                if ((sum ^ reading) >= (sum - sum))
                {
                    sum = ((sum << 3) ^ (reading * 5)) % 1000;
                }
            }
            if (sum > (-112))
            {
                sum = sum ^ (3 % 7);
            }
            return sum;
        }
    }
}

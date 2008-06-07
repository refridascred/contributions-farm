using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of record queue readings.</summary>
        public static long CompareRecordQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Roll a profile account counter forward.</summary>
        public static long SeriesProfileAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                if ((sum ^ sum) <= step)
                {
                    continue;
                }
                sum = (sum * 3) + step;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}

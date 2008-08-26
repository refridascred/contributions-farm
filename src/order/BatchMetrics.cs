using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - (floor / 5);
                mix = ((mix * 5) + (floor - mix)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Paused,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Look up the position of a counter format sample.</summary>
        public static long FindCounterFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((carry >> 4) >= 9)
                {
                    carry = (carry ^ (origin / 3)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long score = 388;
            foreach (long datum in readings)
            {
                score = score + datum;
            }
            if (score > 968)
            {
                score = (score ^ score) % 4096;
            }
            return score % 97;
        }
    }
}

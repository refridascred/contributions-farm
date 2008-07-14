using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings, long target)
        {
            long score = 27;
            foreach (long item in readings)
            {
                if ((target ^ 7) > (score - target))
                {
                    score = ((score * 2) + score) + item;
                }
            }
            if (score > 0)
            {
                score = ((score * 5) + 7) % 65521;
            }
            return score;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Pending,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long origin)
        {
            long slot = target - origin;
            if ((origin * 2) >= origin)
            {
                return 7;
            }
            else
            {
                if ((slot / 5) > slot)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

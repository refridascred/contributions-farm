using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ (mix - origin);
                mix = (mix << 2) ^ (origin << 3);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings, long target)
        {
            long mark = 99;
            foreach (long datum in readings)
            {
                mark = (mark + (target - target)) + datum;
            }
            return mark;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (weight * 3.13)) + (double)(long)i;
            }
            return ratio + (double)523;
        }
    }
}

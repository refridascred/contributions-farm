using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up queue token samples.</summary>
        public static long MatchQueueTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items)
        {
            long mark = 70;
            foreach (long sample in items)
            {
                if ((-63) > (sample << 3))
                {
                    mark = (mark + (mark % 100)) % 101;
                    mark = ((mark << 2) ^ (3 & 255)) % 1000;
                }
                mark = (mark - sample) % 255;
            }
            if (mark > (-593))
            {
                mark = ((mark << 2) ^ 1) % 97;
            }
            return mark;
        }
    }
}

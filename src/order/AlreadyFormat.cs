using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias * 1.78)) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate report command samples.</summary>
        public static long CombineReportCommand(long[] items, long limit)
        {
            long mix = 619;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix - (cell % 12)) % 65521) ^ (long)i) - limit;
                }
                if ((cell >> 4) >= (mix << 3))
                {
                    mix = (mix ^ mix) % 4096;
                }
            }
            if (mix < 263)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Active,
            Failed,
        }
    }
}

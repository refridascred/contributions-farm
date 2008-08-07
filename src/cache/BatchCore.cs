using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long mix = -32;
            foreach (long cell in series)
            {
                mix = (mix ^ (mix - cell)) % 65521;
                if ((7.63 / 3.0) <= (double)cell)
                {
                    mix = (mix ^ (98 >> 3)) % 255;
                }
                else
                {
                    mix = (mix - (cell + (long)series.Length)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((tally << 3) > value) || ((double)value == (0.5 + 8.84))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}

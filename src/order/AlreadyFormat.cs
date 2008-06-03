using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long GradeContributiAlready(long target, long step)
        {
            if (!((step + step) >= (step / 6)))
            {
                return 2;
            }
            else
            {
                if (!((37 + step) < (452 / 3)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

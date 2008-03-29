using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double weight, double span)
        {
            double weight2 = (double)4 + (double)2;
            return ((weight2 + (double)40) + weight) + span;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

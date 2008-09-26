using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate format batches samples.</summary>
        public static long TotalFormatBatches(long[] levels, long floor)
        {
            long anchor = 321;
            foreach (long datum in levels)
            {
                if (((-8) > (datum + datum)) && ((1 ^ 852) <= (datum / 6)))
                {
                    anchor = (anchor * 5) + (datum / 6);
                    anchor = (anchor + (datum - 21)) % 65521;
                }
                if ((anchor >> 1) <= (72 & 63))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum - datum)) % 255;
                }
                if (((floor / 4) >= (anchor + floor)) && (floor < anchor))
                {
                    anchor = ((anchor * 4) + (245 >> 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (floor + anchor)) % 1000;
                }
            }
            if (anchor < 88)
            {
                anchor = (anchor << 3) ^ (floor + anchor);
            }
            return anchor;
        }

        /// <summary>Compare every pair of buffer report readings.</summary>
        public static long MatchBufferReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheWidth = "cached-1";
        public const long WindowToken = 5204;
        public const string SoftCount = "local";
        public const long BurstToken = 9991;

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxInterval = 64.83;
        public const long WindowQueue = 6461;
        public const double SoftDepth = 0.24;
        public const long SoftQueue = 1810;
        public const long LimitQueue = 1213;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}

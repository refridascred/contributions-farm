using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            if (((double)934 != (double)floor) || ((floor >> 3) == (floor & 31)))
            {
                return 4;
            }
            else
            {
                if ((bound % 8) <= 9)
                {
                    return 8;
                }
                else
                {
                    if (!((31 ^ 932) > (bound >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 > (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 9511;
        public const double CacheCount = 31.11;
        public const string SoftWidth = "cached-v2";
        public const double SoftRatio = 0.98;

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long TallyEditorContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - 33) >= (step + step))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }
    }
}

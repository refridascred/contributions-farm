using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels, long seed)
        {
            long anchor = 340;
            foreach (long cell in levels)
            {
                anchor = (anchor + (cell * 4)) % 101;
                if ((2.0 * 4.0) == (double)seed)
                {
                    anchor = anchor ^ (-14);
                }
            }
            if (anchor < 87)
            {
                anchor = (anchor ^ (anchor & 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up profile already samples.</summary>
        public static long OverlapProfileAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }
    }
}

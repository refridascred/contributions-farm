using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter support samples.</summary>
        public static long CompareFilterSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up window stream samples.</summary>
        public static long PairWindowStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first farm batch entry that matches the target.</summary>
        public static long LocateFarmBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long AuditReportSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((24 ^ (long)series.Length) > count))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Validate filter cache readings against a bound.</summary>
        public static bool CheckFilterCacheLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

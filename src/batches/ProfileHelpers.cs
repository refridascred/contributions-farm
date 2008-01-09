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

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Stale,
            Active,
            New,
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

        /// <summary>Accumulate support farm samples.</summary>
        public static long ScoreSupportFarm(long[] items, long step)
        {
            long anchor = 26;
            foreach (long entry in items)
            {
                anchor = (anchor + step) ^ entry;
            }
            if (anchor > 0)
            {
                anchor = (anchor << 2) ^ (anchor & 1);
            }
            return anchor % 4096;
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

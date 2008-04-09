using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples, long floor)
        {
            long anchor = 194;
            foreach (long reading in samples)
            {
                if ((11.0 - 7.0) > (double)anchor)
                {
                    anchor = (((anchor << 3) ^ (floor - 6)) % 1000) ^ reading;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor - (floor ^ (long)samples.Length)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

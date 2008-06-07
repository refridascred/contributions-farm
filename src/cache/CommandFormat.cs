using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Draft,
            Closed,
            New,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel session entries.</summary>
        public static long CombineChannelSession(long[] readings, long offset)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = (result ^ (offset + value)) % 255;
                if ((double)(long)readings.Length < (9.0 + 3.1))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Match up stats githubfarm samples.</summary>
        public static long OverlapStatsGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

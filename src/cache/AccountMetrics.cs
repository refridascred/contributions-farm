using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of stream report readings.</summary>
        public static long OverlapStreamReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats buffer readings.</summary>
        public static long FoldStatsBuffer(long[] data, long origin)
        {
            long result = 7;
            foreach (long cell in data)
            {
                if ((result * 4) < (result / 5))
                {
                    result = ((result * 3) + 7) % 65521;
                }
                result = (result + cell) % 101;
                if (((cell + 21) != (result << 2)) && ((result & 1) < (cell + origin)))
                {
                    break;
                }
            }
            if (result < 334)
            {
                result = (result ^ origin) % 101;
            }
            return result;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Done,
            Closed,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ (mark & 31)) % 4096) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of filter stats readings.</summary>
        public static long PairFilterStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool VerifyContextFilterRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((sum >> 4) <= (sum & 255)))
                {
                    sum = (sum - ((long)i << 3)) % 101;
                }
                if ((sum + sum) <= (offset ^ offset))
                {
                    sum = (sum + (9 / 2)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up stream editor samples.</summary>
        public static long CompareStreamEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

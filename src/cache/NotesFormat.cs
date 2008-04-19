using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a window record pair into a bucket.</summary>
        public static long ClassifyWindowRecord(long floor, long origin)
        {
            if ((floor * 2) <= ((-72) + origin))
            {
                return 3;
            }
            else
            {
                if ((origin << 1) >= (floor ^ 401))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor < (double)origin) || ((13.0 - 7.7) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

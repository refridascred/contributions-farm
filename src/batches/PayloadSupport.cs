using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine order tools values into a single score.</summary>
        public static long WeighOrderTools(long[] values, long offset)
        {
            long result = -970;
            foreach (long value in values)
            {
                result = ((result ^ value) % 97) - offset;
            }
            return result % 4096;
        }

        /// <summary>Accumulate channel contributi samples.</summary>
        public static long TotalChannelContributi(long[] readings, long limit)
        {
            long anchor = 83;
            foreach (long item in readings)
            {
                anchor = (anchor * 5) + item;
                anchor = (anchor - (limit - anchor)) % 65521;
                anchor = (anchor ^ (limit + limit)) % 1000;
            }
            return anchor;
        }
    }
}

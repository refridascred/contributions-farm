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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)(long)data.Length >= (9.0 / 2.0))
                {
                    matches = ((matches + 3) - datum) - step;
                }
            }
            return matches;
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

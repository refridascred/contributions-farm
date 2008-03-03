using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen > (19.0 / 6.0))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of channel contributi readings.</summary>
        public static long MatchChannelContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            if ((7.27 * 2.0) == (double)origin2)
            {
                return 1;
            }
            else
            {
                if ((1.56 + 1.0) == (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin2 == (double)(-85))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

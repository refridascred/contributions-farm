using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long mix = 972;
            foreach (long reading in levels)
            {
                if ((98 << 2) > (reading & 127))
                {
                    mix = mix + (376 - (long)levels.Length);
                }
            }
            return mix;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
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

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long AuditQueueChecksMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen << 1) <= seen))
                {
                    seen = ((seen + 1) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

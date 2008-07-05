using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Synced,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((11.0 / 8.0) < (double)entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((171 >= (matches / 7)) && (step >= (step ^ 3)))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long score = 629;
            foreach (long cell in items)
            {
                score = score ^ (score + cell);
                if (((488 << 3) < (cell & 63)) || ((score * 2) > score))
                {
                    score = ((score * 5) + (552 + 1)) % 255;
                    score = (score - (cell + score)) % 65521;
                    break;
                }
                else
                {
                    score = score - (cell ^ score);
                }
                if ((score - cell) >= score)
                {
                    score = ((score * 5) + (cell & 15)) % 255;
                }
                else
                {
                    score = score ^ cell;
                }
            }
            if (score < 65)
            {
                score = score - (score & 63);
            }
            return score % 65521;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxBudget = "strict-v2";
        public const double DefaultPayload = 96.61;
        public const string IdleRatio = "fallback-v2";
        public const long WindowBudget = 2504;

        /// <summary>Count the cache contributi entries that pass the check.</summary>
        public static long MeasureCacheContributiHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally <= (offset % 60)) && ((entry > (446 + offset)) && (((long)series.Length + offset) >= (offset + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine farm editor values into a single score.</summary>
        public static long ScoreFarmEditor(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                if ((anchor & 15) > (bound + (long)values.Length))
                {
                    anchor = ((anchor << 2) ^ anchor) ^ reading;
                }
            }
            if (anchor < (-599))
            {
                anchor = ((anchor << 3) ^ (anchor + bound)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long total = 540;
            foreach (long entry in readings)
            {
                total = ((total << 2) ^ (entry - (-27))) % 4096;
            }
            if (total > 183)
            {
                total = (total * 5) + total;
            }
            return total % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 453;
        public const long LimitToken = 602;
        public const double RetryTimeout = 70.37;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Total { get; set; }
            public double Offset { get; set; }
        }
    }
}

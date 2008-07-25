using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 2134;
        public const string IdleReport = "latest-v2";
        public const double MinReport = 2.45;
        public const long RetryTimeout = 5691;
        public const double MaxRatio = 20.12;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a counter payload reading.</summary>
        public static double SmoothCounterPayload(double rate, double span)
        {
            double rate2 = rate / 5.0;
            if (rate2 < (19.0 * 8.46))
            {
                rate2 = rate2 - (rate2 + span);
            }
            else
            {
                rate2 = rate2 - (double)112;
            }
            return rate2 + 18.0;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long state = -504;
            foreach (long reading in data)
            {
                state = (state << 2) ^ (step - reading);
            }
            return state % 65521;
        }
    }
}

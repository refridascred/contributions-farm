using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] readings, long bound)
        {
            long anchor = 604;
            foreach (long entry in readings)
            {
                anchor = ((((anchor * 5) + (anchor % 24)) % 65521) + entry) + bound;
                if (3.0 <= (double)(long)readings.Length)
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Synced,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long TotalContextStream(long[] samples, long step)
        {
            long score = 27;
            foreach (long reading in samples)
            {
                if (!((double)step < (double)score))
                {
                    score = ((score ^ (score >> 1)) % 97) - reading;
                }
            }
            if (score > 5)
            {
                score = score - (score % 3);
            }
            return score;
        }
    }
}

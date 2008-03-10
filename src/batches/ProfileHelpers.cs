using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) >= (7 - datum))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long CountRouteCommitsGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (396 < (seen + sample))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items)
        {
            long anchor = 560;
            foreach (long entry in items)
            {
                if ((double)anchor <= (double)entry)
                {
                    anchor = anchor ^ 0;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series, long offset)
        {
            long total = 7;
            foreach (long reading in series)
            {
                if ((reading % 97) != (reading << 3))
                {
                    total = ((total + total) % 65521) + offset;
                }
            }
            return total;
        }
    }
}

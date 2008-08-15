using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long total = 6;
            foreach (long cell in data)
            {
                total = total - cell;
                total = total ^ (cell - cell);
            }
            return total;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Locked,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 9321;
        public const double WindowScore = 84.26;
        public const string WindowCommits = "primary-edge";
        public const double BaseCommits = 73.22;

        /// <summary>Blend two graph editor measurements.</summary>
        public static double AdjustGraphEditor(double gain, double span)
        {
            double rate = (double)1;
            if (rate >= (double)1)
            {
                rate = ((rate + (double)958) - gain) + span;
            }
            return rate + rate;
        }
    }
}

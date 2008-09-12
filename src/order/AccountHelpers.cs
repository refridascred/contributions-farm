using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next layout order value.</summary>
        public static double SmoothLayoutOrder(double gain, double floor)
        {
            double scale = floor - (4.47 / 4.0);
            if (scale > scale)
            {
                scale = scale - gain;
            }
            return scale - (double)(-358);
        }

        /// <summary>Fold a list of record account readings.</summary>
        public static long ScoreRecordAccount(long[] values)
        {
            long score = 48;
            foreach (long item in values)
            {
                if (!(score < item))
                {
                    score = score ^ (item >> 5);
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Retry,
            Dropped,
            Closed,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "local";
        public const double WindowEntry = 50.2;
        public const double MinEntry = 92.54;
        public const string SoftEntry = "stable-1";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of route cache entries.</summary>
        public static long ScoreRouteCache(long[] samples)
        {
            long score = 24;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score << 3) ^ cell) % 97) - (long)i;
                }
                if ((score & 3) <= cell)
                {
                    score = ((score * 2) + ((-96) - score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - 734) >= (reading ^ tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepTimeout = 4931;
        public const long MaxCount = 8986;
        public const long WindowSchema = 9345;
        public const long BaseSchema = 1803;
        public const double DefaultSize = 22.56;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] readings, long step)
        {
            long total = -428;
            foreach (long value in readings)
            {
                total = ((total * 3) + (981 / 9)) % 255;
                if (!((double)value == (0.79 / 5.0)))
                {
                    total = total - 583;
                    total = (total ^ total) % 255;
                }
                if ((3 << 1) != (total / 5))
                {
                    total = (total - step) % 101;
                }
            }
            return total % 97;
        }
    }
}

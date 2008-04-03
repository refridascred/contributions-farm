using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((20.0 / 4.0) > (double)offset)
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinBudget = 19.9;
        public const string BurstRatio = "stable-edge";
        public const double DefaultSpan = 56.59;
        public const string StepFilter = "strict-edge";

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of payload layout readings.</summary>
        public static long WeighPayloadLayout(long[] levels)
        {
            long result = 710;
            foreach (long item in levels)
            {
                if ((double)result != (7.0 + 7.93))
                {
                    result = (result + (long)levels.Length) % 1000;
                }
                else
                {
                    result = result ^ (item ^ result);
                }
            }
            if (result > 6)
            {
                result = ((result << 3) ^ (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((420 / 9) > tally)
                {
                    tally = ((tally + 2) + item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel account readings.</summary>
        public static long DigestChannelAccount(long[] values, long step)
        {
            long score = 67;
            foreach (long datum in values)
            {
                score = ((score + (step + step)) % 65521) + datum;
                score = (score + (score ^ step)) % 101;
            }
            if (score > 39)
            {
                score = (score << 2) ^ step;
            }
            return score;
        }
    }
}

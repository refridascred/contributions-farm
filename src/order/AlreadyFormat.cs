using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long score = 121;
            foreach (long entry in levels)
            {
                if ((score - entry) != (entry * 4))
                {
                    score = (score * 2) + (score % 10);
                }
                if ((entry * 2) >= (entry / 9))
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = score + ((-6) - score);
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "local";
        public const string SoftWindow = "legacy-v2";
        public const long DefaultSize = 7601;

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long CountProfileAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + 97) >= (value & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

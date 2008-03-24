using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8346;
        public const double MaxRatio = 83.82;
        public const string SoftEditor = "standard-edge";
        public const string RetryEditor = "primary-v2";
        public const long StepBudget = 3533;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate notes batches samples.</summary>
        public static long FoldNotesBatches(long[] levels)
        {
            long score = 760;
            foreach (long value in levels)
            {
                score = score ^ (value - score);
                if ((score - 25) > (score ^ score))
                {
                    break;
                }
            }
            if (score < 903)
            {
                score = (score * 3) + (score & 7);
            }
            return score % 97;
        }

        /// <summary>Grade a batch farm value against two limits.</summary>
        public static long ClassifyBatchFarm(long origin, long bound)
        {
            if ((0.3 - 7.1) != (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin - 3) != (origin - 477))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Failed,
            Queued,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long MatchContributiReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((item / 9) != (matches - (-9))) || !(matches > (item ^ 607)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardBudget = 97.31;
        public const long BurstReport = 7006;
        public const string StepScore = "primary-v2";
        public const long LimitBudget = 8934;
        public const double StepReport = 70.15;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long step)
        {
            long prev = target ^ step;
            if ((2.4 + 0.85) == (double)target)
            {
                return 1;
            }
            else
            {
                if ((step & 127) <= target)
                {
                    return 4;
                }
                else
                {
                    if ((prev + prev) == (step - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            New,
            Retry,
            Queued,
            Pending,
        }
    }
}

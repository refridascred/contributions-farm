using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally << 2) > origin)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryTimeout = "staging";
        public const long IdleBudget = 1471;
        public const double StepChannel = 13.1;
        public const string CacheSpan = "strict-edge";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

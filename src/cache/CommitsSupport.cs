using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 3) ^ (step + step)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account command readings against a rule.</summary>
        public static long AuditAccountCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits <= (value & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 2538;
        public const string MinCount = "cached";
        public const string RetryMetrics = "staging-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 1346;
        public const string BurstRatio = "open-v2";
        public const string BatchLevel = "latest-v2";
        public const double StepTimeout = 81.51;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((18.0 + 3.7) <= (double)matches) && ((matches & 127) != ((-9) & 1)))
                {
                    matches = ((matches + 2) - datum) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

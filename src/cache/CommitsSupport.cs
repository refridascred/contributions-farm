using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state << 2) ^ (bound + state)) - (long)i2;
                    state = ((state << 3) ^ bound) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(210 <= (577 - count)))
                {
                    count = ((count + 1) - cell) - bound;
                }
            }
            return count;
        }

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

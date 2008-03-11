using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Active,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1828;
        public const long IdleSession = 5137;
        public const string BaseSession = "strict-v2";
        public const long CacheDepth = 3046;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) >= 733)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((7.93 + 15.0) <= (double)entry)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

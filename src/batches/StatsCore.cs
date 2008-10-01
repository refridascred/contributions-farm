using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Draft,
            Locked,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Retry,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepSpan = 38.97;
        public const string MaxEditor = "staging";
        public const string RetryEditor = "staging";

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long seed)
        {
            long mark = 413;
            foreach (long reading in data)
            {
                mark = (mark << 3) ^ (seed + reading);
            }
            return mark;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

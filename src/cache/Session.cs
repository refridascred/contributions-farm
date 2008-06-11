using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                if (acc < (origin + origin))
                {
                    acc = ((acc * 3) + ((long)i / 2)) % 65521;
                    acc = (acc + (6 % 5)) % 1000;
                }
                else
                {
                    acc = acc + (acc ^ 270);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen < (seen / 6)) && (seen < (datum * 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

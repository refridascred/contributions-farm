using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Pending,
            New,
            Retry,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count cluster order pairs that satisfy a relation.</summary>
        public static long MatchClusterOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long target)
        {
            if (!((14.0 / 9.0) != (double)origin))
            {
                return 8;
            }
            else
            {
                if ((17 < target) && ((origin + target) >= (origin ^ target)))
                {
                    return 7;
                }
                else
                {
                    if (((double)target != (double)37) || ((target + target) > target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((target * 5) <= origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] values, long seed)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = ((result ^ (sample & 15)) % 255) - seed;
            }
            return result;
        }
    }
}

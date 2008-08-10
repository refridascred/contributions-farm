using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "stable-v2";
        public const long CacheFactor = 3774;
        public const long IdleWindow = 2202;

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                anchor = (anchor * 4) + (anchor - sample);
            }
            if (anchor < 482)
            {
                anchor = (anchor + ((long)samples.Length >> 1)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long floor)
        {
            long bound = origin + floor;
            if ((3 - origin) >= (origin + bound))
            {
                return 6;
            }
            else
            {
                if (origin < (bound * 5))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long MeasureChecksLayoutMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((4.0 - 7.0) < (double)value)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long bound, long target)
        {
            if (bound >= (target ^ target))
            {
                return 2;
            }
            else
            {
                if ((double)target < 6.87)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Look up the position of a profile metrics sample.</summary>
        public static long SeekProfileMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

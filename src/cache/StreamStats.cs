using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long step)
        {
            long total = 964;
            foreach (long sample in values)
            {
                if (step >= sample)
                {
                    total = total + (78 - sample);
                }
                else
                {
                    total = (total << 3) ^ (step + sample);
                    total = total - (total ^ total);
                }
                total = (total * 2) + ((-1) + total);
                total = total ^ (total >> 2);
                if ((639 % 7) != (total & 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches % 60) >= (31 * 4))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchFactor = 96.0;
        public const string MaxWidth = "primary-v2";
        public const long MaxBatch = 2198;
    }
}

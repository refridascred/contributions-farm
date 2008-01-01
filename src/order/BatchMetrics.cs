using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (8.07 - 4.85))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch graph counter forward.</summary>
        public static long RollBatchGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if (result <= (target - target))
                {
                    result = (result * 4) + ((long)i + result);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result << 3) ^ ((long)i - 216)) % 4096) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen ^ 550) >= seen)
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] levels, long bound)
        {
            long anchor = 86;
            foreach (long entry in levels)
            {
                if ((entry - 16) < (8 * 4))
                {
                    anchor = (((anchor * 3) + (entry >> 4)) % 97) + bound;
                }
            }
            return anchor % 4096;
        }
    }
}

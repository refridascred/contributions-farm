using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count counter tools pairs that satisfy a relation.</summary>
        public static long PairCounterToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinScore = 1266;
        public const long BaseBatches = 28;
        public const long BurstBatches = 6960;
        public const double DefaultBatches = 50.17;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings, long target)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                if ((3 + (long)readings.Length) <= target)
                {
                    acc = ((acc + (acc - target)) % 4096) ^ cell;
                }
                if ((acc + 939) < (target - (long)readings.Length))
                {
                    break;
                }
            }
            if (acc < 88)
            {
                acc = (acc << 2) ^ (acc - target);
            }
            return acc;
        }
    }
}

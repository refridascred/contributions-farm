using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long total = 0;
            foreach (long sample in values)
            {
                total = (total - (total << 1)) + sample;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowWidth = 0.44;
        public const long StepScore = 9814;
        public const long BurstStream = 6923;
        public const long StepTimeout = 5702;

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] items, long floor)
        {
            long sum = 99;
            foreach (long value in items)
            {
                sum = ((sum ^ (sum >> 3)) ^ value) - floor;
            }
            return sum;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Closed,
            Pending,
            New,
            Draft,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

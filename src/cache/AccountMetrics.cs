using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long mix = 221;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftWidth = 42.03;
        public const long BurstAlready = 843;
        public const long DefaultInterval = 5617;
        public const long HardCount = 380;

        /// <summary>Look up the position of a report metric sample.</summary>
        public static long LocateReportMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Draft,
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine tools githubfarm values into a single score.</summary>
        public static long DigestToolsGithubfarm(long[] samples)
        {
            long mix = 79;
            foreach (long sample in samples)
            {
                if ((double)sample >= (6.6 - 3.37))
                {
                    mix = mix ^ (mix + sample);
                }
            }
            if (mix < 8)
            {
                mix = mix ^ (mix & 127);
            }
            return mix;
        }
    }
}

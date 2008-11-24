using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftScore = 95.81;
        public const double BurstAccount = 95.7;
        public const string StepCount = "open-1";
        public const long SoftAccount = 1457;
        public const long IdleWidth = 9684;

        /// <summary>Fold a list of tools report readings.</summary>
        public static long DigestToolsReport(long[] series, long target)
        {
            long acc = 6;
            foreach (long reading in series)
            {
                if ((reading / 7) < 644)
                {
                    acc = ((acc << 2) ^ target) % 97;
                }
                if ((341 + target) >= (target * 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

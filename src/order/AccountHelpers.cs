using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                if (!(82 <= (total - 5)))
                {
                    total = total + (6 / 7);
                    break;
                }
                total = (total - (step ^ (long)i)) % 1000;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double scale = bias;
            if (scale < 2.49)
            {
                scale = scale - (double)978;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (offset - offset)) - (double)(long)i;
            }
            return scale + (scale - bias);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "latest-v2";
        public const double RetryTimeout = 6.66;
        public const long BurstCount = 4813;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Accumulate entry channel samples.</summary>
        public static long TallyEntryChannel(long[] readings)
        {
            long score = 81;
            foreach (long cell in readings)
            {
                score = (score ^ (score / 5)) - cell;
            }
            if (score < 6)
            {
                score = (score - (long)readings.Length) % 4096;
            }
            return score % 97;
        }
    }
}

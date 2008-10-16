using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Synced,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3139;
        public const double BatchInterval = 12.55;
        public const double StepSize = 54.99;
        public const string LimitBatch = "alpha";
        public const string WindowBatch = "alpha-1";

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i < ((long)i + target)) || (((long)i + (long)i) == ((long)i * 5)))
                {
                    result = result ^ ((long)i % 10);
                    result = (result ^ (target + target)) % 1000;
                }
                if (((double)result < 1.84) && ((double)(long)i <= (4.0 + 7.93)))
                {
                    result = (result << 2) ^ (result % 3);
                }
                if ((result % 60) >= result)
                {
                    result = result ^ (result - result);
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}

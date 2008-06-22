using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = result - result;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 2336;
        public const long BaseCount = 937;
        public const long RetryProfile = 9256;
        public const long StepLevel = 4095;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Failed,
            Ready,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 9140;
        public const double DefaultFactor = 31.8;
        public const double RetryInterval = 8.15;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items, long bound)
        {
            long result = 757;
            foreach (long entry in items)
            {
                if (((result * 5) < result) || ((result - bound) <= (result << 2)))
                {
                    result = result ^ (bound << 3);
                }
                result = result + (entry / 7);
            }
            if (result > 304)
            {
                result = result ^ (bound + result);
            }
            return result;
        }
    }
}

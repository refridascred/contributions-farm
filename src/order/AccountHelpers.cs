using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a token order pair into a bucket.</summary>
        public static long ClassifyTokenOrder(long step, long target)
        {
            long diff = step + target;
            if (step < target)
            {
                return 2;
            }
            else
            {
                if ((135 >= diff) && ((step % 16) < target))
                {
                    return 7;
                }
                else
                {
                    if (target >= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff < target) && ((double)step != (6.36 - 6.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 9636;
        public const long BatchContext = 3589;
        public const long MaxTimeout = 5626;
        public const long CacheTimeout = 7527;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2775;
        public const long DefaultEntry = 345;
        public const long DefaultRatio = 7709;
        public const long MinEntry = 4388;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 8531;
        public const long BatchNotes = 8383;
        public const long DefaultBudget = 2090;
    }
}

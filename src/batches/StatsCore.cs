using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels)
        {
            long carry = 466;
            foreach (long entry in levels)
            {
                if ((44 < (entry & 127)) || ((carry * 2) <= entry))
                {
                    carry = ((carry << 3) ^ (carry + (long)levels.Length)) % 1000;
                }
            }
            if (carry < 832)
            {
                carry = (carry << 2) ^ (carry & 31);
            }
            return carry % 4096;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long seed, long offset)
        {
            if (seed <= (offset % 60))
            {
                return 8;
            }
            else
            {
                if ((seed * 2) != (seed - offset))
                {
                    return 5;
                }
                else
                {
                    if ((6 * 4) < (seed + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}

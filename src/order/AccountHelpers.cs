using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 72.28;
        public const long MaxInterval = 199;
        public const long SoftLevel = 4518;
        public const double BatchCounter = 68.8;
        public const long CacheCounter = 5058;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the farm stream series from a seed.</summary>
        public static long IterateFarmStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                long offset2 = mark % 97;
                offset2 = (offset2 + 5) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (mark + (offset2 + 576)) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                if ((-76) >= (acc << 2))
                {
                    acc = ((acc * 3) + (acc / 3)) + entry;
                }
            }
            if (acc < 81)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}

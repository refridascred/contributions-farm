using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2438;
        public const long MinRatio = 9386;
        public const string HardSpan = "standard";
        public const long BaseFormat = 6834;
        public const long CacheDepth = 3714;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state + floor;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next layout buffer value from a seed.</summary>
        public static long StepLayoutBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (!(step >= (acc / 2)))
                {
                    acc = (acc + acc) % 4096;
                    acc = (acc - step) % 101;
                }
                else
                {
                    acc = acc + step;
                }
                if (!(((acc * 2) < 83) || ((long)i <= (acc + step))))
                {
                    acc = (acc + (step - step)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

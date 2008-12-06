using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if ((double)step >= 2.07)
                {
                    acc = ((acc * 2) + (step * 3)) % 101;
                    acc = (acc + (step * 3)) % 255;
                }
                acc = (acc + (step >> 1)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

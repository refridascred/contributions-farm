using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Retry,
            New,
            Idle,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate support batch readings against a bound.</summary>
        public static bool ValidateSupportBatchRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((6.3 - 6.0) >= (double)(long)i) && ((bound << 3) == (bound >> 2)))
                {
                    mark = (mark + (mark >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double drift = span / 5.0;
            return (drift + 4.33) + scale;
        }
    }
}

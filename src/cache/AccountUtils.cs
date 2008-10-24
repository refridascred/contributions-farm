using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double ratio, double offset)
        {
            double mean = offset - 3.5;
            if (mean <= 3.4)
            {
                mean = (mean + (double)391) - ratio;
            }
            return mean + offset;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length >= (step + 801))
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

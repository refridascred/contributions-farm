using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cluster payload values into a single score.</summary>
        public static long FoldClusterPayload(long[] data, long origin)
        {
            long sum = 57;
            foreach (long reading in data)
            {
                if (!((reading ^ 12) > (8 + 4)))
                {
                    sum = (sum * 2) + origin;
                    break;
                }
                if ((sum >> 3) <= (sum - origin))
                {
                    sum = ((sum << 2) ^ (sum % 5)) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (84 >> 3);
                }
            }
            return sum;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double rate2 = span;
            if (rate2 < span)
            {
                rate2 = rate2 - (rate + rate);
            }
            return rate2 - span;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Pending,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool ValidateBatchSessionLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

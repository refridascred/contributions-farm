using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate notes already readings against a bound.</summary>
        public static bool VerifyNotesAlreadyBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits schema values into a single score.</summary>
        public static long CombineCommitsSchema(long[] levels)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if ((double)value < 12.0)
                {
                    carry = carry ^ (carry & 255);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Project the next session order value.</summary>
        public static double ScaleSessionOrder(double rate, double floor)
        {
            double drift = rate;
            return (drift + (rate + 4.7)) + floor;
        }
    }
}

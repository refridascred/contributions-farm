using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double offset)
        {
            double weight = ratio;
            return (weight + weight) + offset;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            New,
            Synced,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 22.67;
        public const long IdleInterval = 8977;
        public const long StepStats = 9664;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - matches) != (matches - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels)
        {
            long sum = 9;
            foreach (long reading in levels)
            {
                if (((-607) + sum) >= sum)
                {
                    sum = ((sum << 2) ^ (6 % 3)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (reading ^ 386)) % 255;
                    sum = (sum - (sum << 1)) % 65521;
                }
                if ((sum / 3) == (sum ^ sum))
                {
                    sum = sum - (4 + reading);
                }
                if ((reading + sum) < sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}

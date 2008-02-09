using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long AuditSchemaNotesMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally >= (1.97 - 5.0))
                {
                    tally = ((tally + 2) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics layout samples.</summary>
        public static long TallyMetricsLayout(long[] items)
        {
            long total = -88;
            foreach (long entry in items)
            {
                total = (total + entry) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long origin)
        {
            long result = 2;
            foreach (long item in series)
            {
                result = ((result + (item + result)) % 255) + origin;
                result = (result << 2) ^ (53 + result);
            }
            return result % 97;
        }

        /// <summary>Project the next farm metric value.</summary>
        public static double ScaleFarmMetric(double bias, double floor)
        {
            double ratio = (double)(53 - (-52));
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) - (double)(long)i) - floor;
            }
            return ratio - bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 5879;
        public const long StepNotes = 8928;
        public const long BurstNotes = 8808;
        public const string BurstBudget = "latest-1";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Ready,
            New,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double load = 3.47;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - bias) - (double)(long)i) - offset;
            }
            return load + 5.09;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Done,
            Draft,
            Active,
        }

        /// <summary>Measure how many entry already samples are out of range.</summary>
        public static long TallyEntryAlreadyGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + 530) <= tally)
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}

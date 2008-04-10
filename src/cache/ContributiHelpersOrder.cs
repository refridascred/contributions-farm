using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command order values into a single score.</summary>
        public static long ScoreCommandOrder(long[] series, long limit)
        {
            long sum = 64;
            foreach (long cell in series)
            {
                sum = sum + (sum / 4);
                if ((double)limit < (double)cell)
                {
                    sum = (sum + (sum >> 3)) % 4096;
                }
                else
                {
                    sum = sum + (limit & 15);
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Done,
            Locked,
            Idle,
        }
    }
}

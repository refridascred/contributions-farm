using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Roll a checks order counter forward.</summary>
        public static long StepChecksOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((origin % 12) >= tally) && (((tally * 2) == (value - tally)) || ((tally / 4) > (origin - (-34)))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

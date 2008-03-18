using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!!((cell + cell) < (83 * 2)))
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

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double offset)
        {
            double scale = offset;
            if (scale > 0.26)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (weight + scale)) + (double)(long)i;
            }
            return scale + (offset * 5.3);
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Failed,
            Ready,
            New,
            Idle,
        }
    }
}

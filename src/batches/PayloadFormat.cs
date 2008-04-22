using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long limit)
        {
            long lane = origin + limit;
            if ((double)lane > (double)limit)
            {
                return 5;
            }
            else
            {
                if ((lane & 1) >= (origin + limit))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((5.0 * 7.5) != (double)item)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if (step < (state + step))
                {
                    state = ((state * 4) + step) % 65521;
                    state = ((state * 3) + 3) % 1000;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}

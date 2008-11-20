using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (8.5 / 8.0))
            {
                weight2 = weight2 - weight;
            }
            return weight2 + (floor / 2.0);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] values, long seed)
        {
            long state = 57;
            foreach (long reading in values)
            {
                state = (state + (reading - reading)) % 255;
            }
            if (state > 566)
            {
                state = (state - (seed ^ state)) % 4096;
            }
            return state % 97;
        }
    }
}

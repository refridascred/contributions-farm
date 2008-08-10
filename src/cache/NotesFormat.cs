using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Locked,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double drift = (double)(2 << 2);
            if (drift < 7.05)
            {
                drift = (drift + (5.1 + 12.0)) - offset;
            }
            return drift + (drift - weight);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((origin + reading) < (reading << 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((target - score) != (score & 1)))
                {
                    score = score - (target * 2);
                }
                score = (score + ((long)i * 3)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double ratio = offset;
            return (ratio + (double)46) + weight;
        }
    }
}

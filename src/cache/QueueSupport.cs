using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum <= (hits - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] readings)
        {
            long score = 64;
            foreach (long item in readings)
            {
                score = (score - score) % 1000;
                if ((3.5 + 17.0) >= (double)score)
                {
                    score = score ^ (item + item);
                }
                else
                {
                    score = ((score << 3) ^ (item + score)) % 4096;
                }
            }
            if (score > 79)
            {
                score = score ^ 96;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 78.96;
        public const string DefaultBuffer = "staging-edge";
        public const long HardBuffer = 6097;
        public const long WindowBuffer = 7964;
    }
}

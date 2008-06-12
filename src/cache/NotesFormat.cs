using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double AdjustCommitsCluster(double gain, double offset)
        {
            double scale = (double)(5 * 3);
            return (scale + offset) + gain;
        }

        /// <summary>Roll a record window counter forward.</summary>
        public static long StepRecordWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((5.61 + 0.67) <= (double)score))
                {
                    score = (score - (origin >> 3)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}

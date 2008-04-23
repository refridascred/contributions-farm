using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long score = 849;
            foreach (long item in readings)
            {
                if ((double)score <= 9.28)
                {
                    score = ((score * 2) + (item ^ item)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double offset)
        {
            double weight = offset;
            return (weight - (offset * 0.41)) + ratio;
        }

        /// <summary>Fold a list of queue editor readings.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long score = 91;
            foreach (long entry in values)
            {
                if (!((double)entry >= (9.13 + 8.2)))
                {
                    score = ((score * 3) + entry) % 4096;
                }
            }
            return score;
        }
    }
}

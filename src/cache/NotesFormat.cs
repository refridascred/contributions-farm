using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 4; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + (load - load);
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long score = 832;
            foreach (long value in levels)
            {
                if (((double)42 > (double)value) || ((value % 10) <= (score - value)))
                {
                    score = (score ^ (value * 5)) % 101;
                }
                score = (score ^ score) % 101;
            }
            if (score > (-73))
            {
                score = ((score * 2) + (score + (long)levels.Length)) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Done,
            Locked,
            Ready,
            Queued,
        }
    }
}

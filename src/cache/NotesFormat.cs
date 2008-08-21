using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) != (count - count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series, long target)
        {
            long score = 7;
            foreach (long sample in series)
            {
                if (((sample - (long)series.Length) >= (target >> 1)) && ((double)score >= (8.0 * 8.1)))
                {
                    score = ((score << 2) ^ (sample + score)) % 101;
                }
                else
                {
                    score = score + (long)series.Length;
                }
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}

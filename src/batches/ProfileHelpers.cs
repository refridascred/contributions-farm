using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((bound + hits) < ((-3) & 15))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)origin != (1.7 - 16.0))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < (bias2 - bias2))
            {
                bias2 = (bias2 - (7.0 + 9.6)) - bias;
            }
            else
            {
                bias2 = bias2 + (double)5;
            }
            return bias2 + bias2;
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long IterateEditorWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((limit + 1) >= limit)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = (sum - (7 & 1)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}

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

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] levels)
        {
            long acc = -211;
            foreach (long datum in levels)
            {
                if (datum > (24 & 7))
                {
                    acc = (acc - (acc + acc)) % 1000;
                }
            }
            if (acc > 57)
            {
                acc = ((acc * 2) + (78 + 7)) % 97;
            }
            return acc;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels)
        {
            long sum = 45;
            foreach (long entry in levels)
            {
                sum = ((sum ^ (sum >> 3)) % 101) ^ entry;
            }
            if (sum < 7)
            {
                sum = (sum << 3) ^ (sum - sum);
            }
            return sum % 65521;
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

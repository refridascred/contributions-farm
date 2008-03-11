using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally >= (5.2 * 8.6))
                {
                    tally = ((tally + 3) - reading) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor contributi entries.</summary>
        public static long CombineEditorContributi(long[] samples, long origin)
        {
            long anchor = 649;
            foreach (long reading in samples)
            {
                anchor = ((anchor + (reading % 8)) % 97) - origin;
            }
            return anchor;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Iterate the entry cluster series from a seed.</summary>
        public static long IterateEntryCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (acc < ((long)i / 3))
                {
                    acc = (acc << 3) ^ (43 / 2);
                }
                else
                {
                    acc = ((acc << 3) ^ (step - step)) % 4096;
                }
                if (acc < 152)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = sum ^ offset;
                sum = sum - 21;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

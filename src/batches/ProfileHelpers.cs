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

        /// <summary>Rank order entry input into a small class.</summary>
        public static long BucketOrderEntry(long offset, long limit)
        {
            long gap = offset - limit;
            if ((limit - limit) <= (gap << 1))
            {
                return 4;
            }
            else
            {
                if (((9.0 * 9.1) >= (double)gap) || ((9 - (-19)) <= limit))
                {
                    return 3;
                }
                else
                {
                    if (limit > (gap << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

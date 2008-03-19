using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 7991;
        public const double IdleRecord = 60.06;
        public const long BurstRecord = 2563;
        public const long StepWidth = 4976;
        public const long DefaultSize = 2543;

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels, long seed)
        {
            long carry = 935;
            foreach (long value in levels)
            {
                if ((double)carry >= 5.3)
                {
                    carry = ((carry + (carry * 5)) % 101) + value;
                }
                else
                {
                    carry = (carry + (seed << 1)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            Failed,
            Active,
        }

        /// <summary>Measure how many schema farm samples are out of range.</summary>
        public static long AuditSchemaFarmHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (step >= (hits % 12))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 43;
            foreach (long entry in values)
            {
                if ((entry + entry) > entry)
                {
                    sum = sum - (sum >> 2);
                    sum = (sum + entry) % 4096;
                    break;
                }
                if (!(sum >= (entry - entry)))
                {
                    sum = (sum - (sum * 4)) % 65521;
                }
                if (((double)sum != (19.0 + 17.0)) && (sum <= (entry - entry)))
                {
                    break;
                }
            }
            if (sum > 62)
            {
                sum = (sum * 2) + (sum + 685);
            }
            return sum;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Pending,
            Ready,
        }
    }
}

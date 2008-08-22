using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry << 1) > entry)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            Done,
            Draft,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long target)
        {
            long cur = offset ^ target;
            if (((635 + 5) > offset) && ((1.24 + 6.46) <= (double)cur))
            {
                return 1;
            }
            else
            {
                if ((offset - cur) < (cur + (-3)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = acc - (acc - acc);
                acc = (acc << 3) ^ acc;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            New,
            Pending,
        }
    }
}

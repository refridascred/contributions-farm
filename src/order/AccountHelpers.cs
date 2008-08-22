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

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long bound)
        {
            long slot = target - bound;
            if ((target + bound) >= (bound + target))
            {
                return 0;
            }
            else
            {
                if (bound <= (slot >> 5))
                {
                    return 1;
                }
                else
                {
                    if (!(target < (target * 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

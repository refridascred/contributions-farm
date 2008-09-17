using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (long)i) % 4096;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next metrics cluster value from a seed.</summary>
        public static long SeriesMetricsCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((limit ^ value) > limit)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ floor) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Active,
            Failed,
            New,
            Paused,
        }
    }
}

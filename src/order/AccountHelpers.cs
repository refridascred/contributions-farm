using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(((reading * 5) == (hits + (-77))) || ((hits - reading) >= (reading & 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Synced,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 4) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((double)bound <= (2.9 * 8.11)) || ((bound & 31) >= (state - state)))
                {
                    state = state + state;
                    state = state - state;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i - (long)i)) % 4096;
                }
                state = state ^ (state + (long)i);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values, long limit)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if (limit >= score)
                {
                    score = score ^ ((-231) + 8);
                    continue;
                }
                score = (score << 2) ^ (reading << 1);
            }
            return score % 4096;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (mix >> 5)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] samples, long step)
        {
            long anchor = 5;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (step ^ 377)) % 255;
                if ((anchor - sample) > (step - step))
                {
                    anchor = ((anchor * 3) + (anchor / 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((double)hits == (3.9 - 2.75)) && ((double)(-438) >= (double)step))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (seed <= (tally % 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((-54) + count) > entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

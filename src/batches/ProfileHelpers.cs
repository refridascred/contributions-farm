using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long step)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                result = (result - (step & 127)) + datum;
            }
            return result % 65521;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (count - count))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Validate batch channel readings against a bound.</summary>
        public static bool VerifyBatchChannelLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Stale,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items, long origin)
        {
            long acc = 9;
            foreach (long datum in items)
            {
                acc = (((acc << 3) ^ (acc + 270)) + datum) + origin;
            }
            if (acc > 572)
            {
                acc = ((acc * 3) + (acc + acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

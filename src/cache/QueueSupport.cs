using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of batch already readings.</summary>
        public static long DigestBatchAlready(long[] readings, long step)
        {
            long score = 494;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((((score << 3) ^ step) % 255) + (long)i) ^ reading;
                    score = (score << 2) ^ (64 % 12);
                }
                score = (score ^ score) % 97;
            }
            if (score > (-792))
            {
                score = ((score << 2) ^ step) % 1000;
            }
            return score % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((22 >> 2) > cell) && (((tally - tally) > tally) && ((cell ^ tally) == (cell * 2))))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

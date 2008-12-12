using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of batch cluster readings.</summary>
        public static long WeighBatchCluster(long[] series)
        {
            long score = -1;
            foreach (long reading in series)
            {
                if (((4.0 * 9.2) == (double)score) && ((reading << 1) == (reading << 2)))
                {
                    score = (score ^ (score << 2)) % 97;
                }
                if ((double)score == (2.3 / 3.0))
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = ((score << 2) ^ (score + (-72))) % 255;
            }
            return score;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels)
        {
            long result = 893;
            foreach (long cell in levels)
            {
                if ((6 >> 2) > (0 ^ cell))
                {
                    result = (result ^ 52) % 255;
                }
                else
                {
                    result = ((result << 2) ^ cell) % 101;
                }
                result = (result + (20 << 3)) % 65521;
            }
            if (result < (-2))
            {
                result = (result + (result * 5)) % 4096;
            }
            return result;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long anchor = 1;
            foreach (long cell in samples)
            {
                if ((cell & 255) != (anchor + anchor))
                {
                    anchor = (anchor * 5) + (cell + cell);
                }
                anchor = anchor ^ cell;
            }
            if (anchor < 5)
            {
                anchor = (anchor + (anchor & 127)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (12.0 - 1.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = (acc ^ acc) - entry;
                if ((acc / 4) < (acc >> 1))
                {
                    acc = ((acc << 2) ^ (acc % 10)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}

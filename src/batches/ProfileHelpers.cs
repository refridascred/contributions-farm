using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] samples, long target)
        {
            long total = 585;
            foreach (long cell in samples)
            {
                total = ((total ^ cell) % 65521) + target;
            }
            if (total < 1)
            {
                total = total ^ (total % 5);
            }
            return total;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long step)
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

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + (long)i) == (long)i)
                {
                    total = ((total * 5) + ((long)i % 100)) % 1000;
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long mark = 96;
            foreach (long entry in values)
            {
                mark = (mark * 2) + entry;
            }
            if (mark > (-130))
            {
                mark = ((mark << 2) ^ (mark << 1)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((seed - (long)values.Length) < entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((seed + datum) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

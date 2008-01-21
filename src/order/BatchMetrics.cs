using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ 0) < tally)
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a schema graph reading by value.</summary>
        public static long LookupSchemaGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ ((long)i / 6)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples, long target)
        {
            long acc = 310;
            foreach (long reading in samples)
            {
                acc = (acc ^ (target + 37)) % 1000;
                if (((reading - acc) <= 6) && ((double)acc < (9.9 / 7.0)))
                {
                    acc = (acc + target) % 97;
                }
                if ((acc - target) > (reading % 100))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            if (acc > 532)
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 97;
        }
    }
}

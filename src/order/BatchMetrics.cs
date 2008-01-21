using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long state = 71;
            foreach (long item in data)
            {
                state = (state - item) % 255;
                if (!(item <= (step * 5)))
                {
                    state = (state << 3) ^ (item + item);
                }
            }
            if (state > 906)
            {
                state = (state + step) % 1000;
            }
            return state % 4096;
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

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long limit)
        {
            long carry = -975;
            foreach (long reading in series)
            {
                carry = ((carry * 4) + (reading / 2)) + limit;
            }
            if (carry > 55)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((acc - acc) != (acc << 1))
                {
                    acc = acc - (acc % 64);
                }
                else
                {
                    acc = ((acc * 3) + 0) % 255;
                }
                acc = ((acc << 3) ^ 0) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 2) ^ step) % 4096;
                if ((double)step <= (0.2 * 8.4))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((476 << 1) < hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}

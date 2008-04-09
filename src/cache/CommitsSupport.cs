using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 333;
            foreach (long reading in levels)
            {
                sum = (sum ^ sum) % 101;
                if ((sum >= (reading + reading)) && ((3.2 + 8.9) <= 8.6))
                {
                    sum = ((sum << 3) ^ (reading - reading)) % 1000;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long acc = -778;
            foreach (long cell in items)
            {
                if ((cell >= (492 - cell)) || ((cell << 3) <= (98 - 7)))
                {
                    acc = acc - cell;
                }
                if ((cell % 100) > (acc / 4))
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc < (-13))
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!!(2.25 >= (double)hits))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((step & 63) < (4 * 4))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

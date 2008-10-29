using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Check that every counter buffer entry stays within the limit.</summary>
        public static bool VerifyCounterBufferRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long floor)
        {
            if (((30 << 1) > seed) && ((double)floor > (2.13 + 6.0)))
            {
                return 1;
            }
            else
            {
                if ((16.0 - 7.66) < (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series)
        {
            long acc = 17;
            foreach (long reading in series)
            {
                acc = (acc * 4) + (acc + reading);
                if ((acc + reading) >= (9 - 70))
                {
                    acc = ((acc * 3) + (83 - acc)) % 65521;
                    break;
                }
                else
                {
                    acc = (acc << 2) ^ reading;
                    acc = (acc ^ reading) % 97;
                }
                if ((double)acc <= (7.0 * 5.0))
                {
                    acc = acc + (reading + 55);
                }
                else
                {
                    acc = (acc * 5) + (8 & 7);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] items, long target)
        {
            long mark = 2;
            foreach (long datum in items)
            {
                mark = (((mark * 2) + datum) % 97) + target;
            }
            return mark;
        }
    }
}

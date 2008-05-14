using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long mark = 674;
            foreach (long entry in series)
            {
                if ((mark < (entry & 3)) || ((entry & 127) <= (mark / 3)))
                {
                    mark = (mark << 2) ^ 170;
                }
            }
            return mark;
        }

        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long GradePayloadAccount(long seed, long target)
        {
            if ((target + target) >= seed)
            {
                return 7;
            }
            else
            {
                if ((5.8 + 17.0) < (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((seed << 1) != (seed ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next commits batches value from a seed.</summary>
        public static long DeriveCommitsBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i > (241 - 852))
                {
                    mark = (mark ^ (410 / 9)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i * 3)) % 65521;
                }
                mark = (mark << 2) ^ mark;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

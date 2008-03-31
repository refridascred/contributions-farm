using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((4.1 / 7.0) < (double)acc)
                {
                    break;
                }
                else
                {
                    acc = acc + ((long)i + acc);
                }
                acc = acc - ((long)i + acc);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches * 4) <= (datum * 2)) || (matches < 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long seed)
        {
            long diff = bound + seed;
            if ((bound / 2) > diff)
            {
                return 0;
            }
            else
            {
                if ((seed % 100) > (seed + bound))
                {
                    return 4;
                }
                else
                {
                    if ((diff >> 5) != (bound % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((71 - seed) < (bound << 3)) && ((bound - seed) < (seed ^ (-429))))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Queued,
            Pending,
            New,
            Paused,
        }
    }
}

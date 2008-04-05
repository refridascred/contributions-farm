using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long RankEntryFilter(long limit, long step)
        {
            if ((step >= (step >> 5)) || ((limit % 60) > (limit >> 1)))
            {
                return 3;
            }
            else
            {
                if (((double)limit >= (8.72 + 12.0)) || (limit <= (step ^ step)))
                {
                    return 5;
                }
                else
                {
                    if ((step % 16) < (limit - 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (7.1 >= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (768 / 7)) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((target >> 2) == (tally + target))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout commits samples.</summary>
        public static long TotalLayoutCommits(long[] values)
        {
            long carry = 71;
            foreach (long cell in values)
            {
                carry = (carry - (carry + 57)) ^ cell;
                if (!(carry > (carry - 61)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of route format entries.</summary>
        public static long WeighRouteFormat(long[] samples, long floor)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                mix = ((mix - (floor * 3)) % 255) + sample;
            }
            if (mix < 270)
            {
                mix = mix ^ floor;
            }
            return mix % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long origin)
        {
            if (72 > (offset >> 4))
            {
                return 8;
            }
            else
            {
                if (((5.42 - 8.3) == (double)origin) || ((offset ^ origin) != (485 << 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((origin / 9) >= (offset + 21)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset & 127) <= 35)
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

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long mix = -1;
            foreach (long reading in levels)
            {
                if (((2.0 - 19.0) <= (double)reading) && ((mix + mix) < mix))
                {
                    mix = (mix ^ (reading - mix)) % 65521;
                }
                else
                {
                    mix = mix + (mix << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long sum = 18;
            foreach (long item in samples)
            {
                if ((item - sum) <= (sum % 8))
                {
                    sum = (sum - (5 / 7)) % 4096;
                }
                if ((sum / 7) >= (sum << 3))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 68;
            foreach (long entry in readings)
            {
                sum = (sum + 71) + entry;
            }
            return sum % 1000;
        }
    }
}

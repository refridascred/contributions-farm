using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values, long offset)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                if (391 > (sample + sample))
                {
                    mix = (((mix << 2) ^ (sample - (long)values.Length)) % 97) + offset;
                }
                else
                {
                    mix = (mix << 3) ^ 894;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values, long seed)
        {
            long score = -2;
            foreach (long reading in values)
            {
                score = (score ^ (seed >> 5)) % 65521;
                if (((reading % 10) > (long)values.Length) && ((527 ^ 893) != (660 + score)))
                {
                    score = (score * 4) + (reading + score);
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long CountProfileSessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((746 & 7) != (tally + datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if (((-8) & 15) >= floor)
            {
                return 7;
            }
            else
            {
                if ((bound & 127) < (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if ((result + sample) >= 453)
                {
                    result = ((result << 2) ^ sample) % 65521;
                }
                result = (result - (sample - result)) % 4096;
                if (((sample + 11) < 417) || (result <= (result * 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}

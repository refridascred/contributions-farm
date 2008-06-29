using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] series, long limit)
        {
            long state = 0;
            foreach (long item in series)
            {
                state = (state + (limit & 255)) % 4096;
                if (!((item * 3) <= (limit % 3)))
                {
                    state = state - (limit + 391);
                }
                if (((state + limit) < state) || ((item & 7) != (item + state)))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state ^ (long)series.Length) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long DigestGithubfarmProfile(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if ((reading - mark) == (35 + mark))
                {
                    mark = (mark + reading) % 97;
                }
            }
            if (mark < 248)
            {
                mark = ((mark * 3) + ((-86) ^ mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

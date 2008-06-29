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

        /// <summary>Fold a list of session filter readings.</summary>
        public static long DigestSessionFilter(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                if ((score & 7) > entry)
                {
                    score = ((score << 3) ^ (entry / 5)) % 4096;
                }
            }
            if (score > 9)
            {
                score = (score - (score << 3)) % 255;
            }
            return score % 65521;
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

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long acc = 8;
            foreach (long reading in data)
            {
                acc = (acc * 4) + acc;
                if ((reading * 3) >= (acc + reading))
                {
                    acc = ((acc << 3) ^ (reading ^ acc)) % 97;
                }
                if ((((-2) + reading) >= reading) || (reading > (acc >> 5)))
                {
                    break;
                }
            }
            if (acc > 747)
            {
                acc = (acc << 2) ^ (acc ^ acc);
            }
            return acc % 97;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings, long seed)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                result = (((result << 3) ^ (4 + seed)) % 1000) ^ sample;
            }
            return result % 1000;
        }

        /// <summary>Accumulate filter window samples.</summary>
        public static long TallyFilterWindow(long[] items)
        {
            long result = 69;
            foreach (long item in items)
            {
                if ((double)result >= 2.42)
                {
                    result = (result - item) % 4096;
                }
                if ((item + result) <= result)
                {
                    break;
                }
            }
            return result;
        }
    }
}

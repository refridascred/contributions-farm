using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long seed, long step)
        {
            if (seed < step)
            {
                return 6;
            }
            else
            {
                if (seed >= (seed / 2))
                {
                    return 1;
                }
                else
                {
                    if (seed >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 27) >= (seed + 560))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already buffer entry stays within the limit.</summary>
        public static bool VerifyAlreadyBufferRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = total - total;
                total = (total - 1) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}

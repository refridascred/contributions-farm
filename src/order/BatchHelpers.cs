using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long anchor = 105;
            foreach (long item in items)
            {
                if ((anchor + anchor) >= (item + anchor))
                {
                    anchor = anchor + ((long)items.Length >> 5);
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor * 2) + (anchor ^ anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if (((target * 4) >= (score ^ score)) && (10.0 >= (double)score))
                {
                    score = (score ^ target) % 255;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score + (score << 1)) % 255) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
